using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using Unilab2019.Objects;
using Unilab2019.Objects.Enemies;
using Unilab2019.Objects.Player;
using Unilab2019.Objects.Goal;
using Unilab2019.Objects.FieldItems;
using Unilab2019.Fields;
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using Unilab2019.Helpers;

namespace unilab2019.Forms
{
    public partial class GameForm : Form
    {
        #region field
        private readonly int _fps;
        private Graphics _graphicsBack, _graphicsFore;
        private readonly HashSet<Keys> _pressedKeys;
        private Field _field;
        private Random _rand;

        public float CellWidth => (float)pictureBox1.Width / _field.Width;
        public float CellHeight => (float)pictureBox1.Height / _field.Height;
        #endregion

        #region code

        /// <summary>
        /// ボタン入力に対して"if"や"for"の形で保存する
        /// </summary>
        public List<Code> code;
        /// <summary>
        /// codeをif,forなどの条件を加味して翻訳したもの。codeと統合する予定
        /// </summary>
        public Stack<IEnumerator> exeCodeStack;
        /// <summary>
        /// ステージごとのコードいれる
        /// </summary>
        public Dictionary<string, List<string>> codeDictionary;
        /// <summary>
        /// ステージごとのコードリストボックスのアイテムを入れる
        /// </summary>
        public Dictionary<string, List<string>> codeListBoxItemsDictionary;
        /// <summary>
        /// ステージごとにゴールしているかどうかを入れる
        /// </summary>
        public Dictionary<string, bool> isGoaledDictionary;
        /// <summary>
        /// 全てのステージをクリアしたかどうか
        /// </summary>
        public bool isAllGoaledFlag; 
        #region old member valiable
        //public Dictionary<string, int> depthDictionary; // ステージごとのコードのdepthを入れる(おそらく途中から再開するため)
        /// <summary>
        /// 無限ループ阻止用措置ただしendの直前がfor,whileならエラーを吐けば不要
        /// </summary>
        //public bool endlessFlag; // 「ずっと」コマンドの中にいて、動作コマンド（前に進む、左を向く、右を向く、回復）が行われていない状態であるかどうか
        //public int depth;
        //public bool canMoveNextCode;  // 同フレーム内で次の行も実行していいかどうか. for・if・end の行を実行した時に true にして使う.
        //public bool canMoveEnemy; // コード実行時のフレーム処理で2フレームに1回だけエネミーが動くようにする
        //public int desiredMP; //　コマンドライン行数の目標値 
        //public int TeleporterPairId; // テレポート時のペアID
        //private Teleporter TeleportDestination; // テレポート先のテレポートマット

        #endregion
        #endregion
        public GameForm()
        {
            InitializeComponent();
        }

        #region ステージ名などが消せなくなるようにするのに必要な関数
        private void TextboxCaretControl(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
            TextBox textbox = (TextBox)sender;
            textbox.Enabled = false;
            textbox.Enabled = true;
        }

        private void TextboxCursorControl(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void TextboxCursorControl(object sender, MouseEventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region 追加メソッド・判別用メソッド
        private void AddEnemy(int x, int y) => _field.Enemies.Add(new Enemy(x, y));

        private void AddTeleporter(int x, int y, int pairId, bool isDestination, Types.Direction direction) => _field.Teleporters.Add(new Teleporter(x, y, pairId, isDestination, direction));

        private bool IsWall(int x, int y) => _field.Walls.Where(w => w.X == x && w.Y == y).Count() > 0;

        private bool IsEnemy(int x, int y) => _field.Enemies.Where(w => w.X == x && w.Y == y).Count() > 0;


        private bool IsTeleporter(int x, int y) => _field.Teleporters.Where(w => w.X == x && w.Y == y && !w.IsDestination).Count() > 0;

        private bool IsRoad(int x, int y)
        {
            return _field.Walls.Where(w => w.X == x && w.Y == y).Count() +
                   _field.Teleporters.Where(w => w.X == x && w.Y == y).Count() == 0;
        }
        #endregion

        #region JSONファイルの読み出し

        //何をやってるか不明？？　
        //private void SaveFieldJson(Field field, string fileName)
        //{
        //    var filePath = Environment.CurrentDirectory + @"\" + fileName + ".json";
        //    var enc = Encoding.GetEncoding("utf-8");

        //    var output = JsonConvert.SerializeObject(field, Formatting.Indented, new JsonSerializerSettings
        //    {
        //        TypeNameHandling = TypeNameHandling.Auto
        //    });

        //    File.WriteAllText(filePath, output, enc);
        //}

        //jsonファイルの読み出し
        private Field ReadFieldJson(string name)
        {
            //現在のコードを実行しているAssemblyを取得
            var myAssembly = Assembly.GetExecutingAssembly();
            var sr = new StreamReader(
                myAssembly.GetManifestResourceStream("Unilab2019.Fields." + name + ".json"),
                    Encoding.GetEncoding("utf-8"));
            var input = sr.ReadToEnd();
            sr.Close();

            var deserialized = JsonConvert.DeserializeObject<Field>(
                input, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return deserialized;
        }
        #endregion

        #region スクリプト実行
        //

        ////コードを実行
        private IEnumerator<Code> CarryOutScript(List<Code> code)
        {
            // 全体で使う変数
            //int i; // 現在実行しているコードのindex
            //string c; // i番目のコード

            // for・until用の変数
            //List<string> subCode; // for文の内側のコード

            for (int i = 0; i < code.Count(); i++)
            {
                switch (code[i].Instruction)
                {
                    //case Types.Instruction.Right:
                    //    if (!IsWall(_field.Player.X + 1, _field.Player.Y)) _field.Player.X++;
                    //    break;

                    //case Types.Instruction.Left:
                    //    if (!IsWall(_field.Player.X - 1, _field.Player.Y)) _field.Player.X--;
                    //    break;

                    //case Types.Instruction.Forward:
                    //    if (!IsWall(_field.Player.X, _field.Player.Y - 1)) _field.Player.Y--;
                    //    break;

                    //case "down":
                    //    if (!IsWall(_field.Player.X, _field.Player.Y + 1)) _field.Player.Y++;
                    //    break;

                    case Types.Instruction.Forward:
                        if (IsWall(_field.Player.ForwardX(), _field.Player.ForwardY()))
                        {
                            MessageBox.Show("前は壁だよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            _field.Player.Pedometer++;
                            _field.Player.Move();
                        }
                        break;

                    case Types.Instruction.Right:
                        _field.Player.Pedometer++;
                        _field.Player.TurnRight();
                        break;

                    case Types.Instruction.Left:
                        _field.Player.Pedometer++;
                        _field.Player.TurnLeft();
                        break;

                    case Types.Instruction.IfCode:

                        break;

                    case Types.Instruction.ForCode:
                        //endの行数を格納する変数
                        int sub_indent = 0;
                        
                        //for文のendを取得
                        for (int k = i; k < code.Count();k++)
                        {
                            if (code[k].Instruction == Types.Instruction.End && code[i].Indent == code[k].Indent)
                            {
                                sub_indent = k;
                                break;
                            }
                        }
                        //中身の部分だけ一時的に取り出すcodeリストを作成
                        List<Code> subcode = new List<Code>();
                        for (int j = i+1; j < sub_indent; j++)
                        {
                            subcode.Add(code[j]);
                        }
                        for (int m = 0; m < code[i].Repeat_num; m ++)
                        {
                            CarryOutScript(subcode);
                        }
                        i = sub_indent

                        break;

                    case "end":
                        break;

                    default:
                        break;
                }
                yield return null;
            }
            yield break;
        }

        // if文・until文の中の最後のコードのindexを返す
        // stopAtElse == true なら, 条件文 == true の else があった時に, その条件文の index を返す
        private int skipSubCode(List<string> code, int i, bool stopAtElse)
        {
            string c;
            string ifType; // if文の条件文の種類. if文の場合に使う.
            int subDepth;

            subDepth = 0;
            while (true)
            {
                i++;
                c = code[i];
                if (c == "elseIf" && subDepth == 0 && stopAtElse)
                {
                    i++;
                    ifType = code[i];
                    if (IfCheck(ifType)) break;
                }
                if (c == "end")
                {
                    if (subDepth == 0)
                    {
                        break;
                    }
                    else
                    {
                        subDepth--;
                    }
                }
                if (c == "if" || c == "for" || c == "until" || c == "endless")
                {
                    subDepth++;
                }
            }

            return i;
        }

        // for文・until文の内側のコードを返す
        private List<string> GetSubCode(List<string> code, int i)
        {
            int j; // 現在いるコードのindex
            int starti; // 内側の最初のコードのindex
            int endi; // 内側の最後のコードのindex
            int subDepth; // 現在いるコードの深さ
            string cj; // j番目のコード

            subDepth = 0;
            starti = i + 1;
            j = i;

            while (true)
            {
                j++;
                cj = code[j];
                if (cj == "end")
                {
                    if (subDepth == 0)
                    {
                        endi = j;
                        break;
                    }
                    else
                    {
                        subDepth--;
                    }
                }
                if (cj == "if" || cj == "for" || cj == "until" || cj == "endless")
                {
                    subDepth++;
                }
            }
            return code.GetRange(starti, endi - starti);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void editCustomSatgeBtn_Click(object sender, EventArgs e)
        {
            var csForm = new CustomStageForm();
            csForm.Show();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void ifComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void startPagePictureBox_Click(object sender, EventArgs e)
        {

        }

        //// コードをチェック
        //// while文を使ったときに無限ループするかどうかを判定
        private void CheckCode()
        {
            for (int i=0; i < code.Count(); i++)
            {
                if (code[i].Instruction == Types.Instruction.WhileCode &&  code[i+1].Instruction == Types.Instruction.End)
                {
                    MessageBox.Show("無限ループしてしまうよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        #endregion
    }
}
