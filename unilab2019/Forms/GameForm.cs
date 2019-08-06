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
        //private readonly HashSet<Keys> _pressedKeys;
        private Field _field;
        //private Random _rand;
        public int TeleporterPairId;
        private Teleporter TeleportDestination;
        public bool canMoveNextCode;
        private int countEnemy;
        public float CellWidth => (float)backPictureBox.Width / _field.Width;
        public float CellHeight => (float)backPictureBox.Height / _field.Height;
        private string stageName = "stage4";
        Selectstage selectStage;
        private List<int> _initial_player_position;

        public float initialCellWidth;
        public float initialCellHeight;
        #endregion

        #region code

        /// <summary>
        /// ボタン入力に対して"if"や"for"の形で保存する
        /// </summary>
        public List<Code> code = new List<Code> { };
        /// <summary>
        /// codeをif,forなどの条件を加味して翻訳したもの。codeと統合する予定
        /// </summary>
        public Stack<IEnumerator> exeCodeStack = new Stack<IEnumerator>();
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
        public Types.Direction _initial_player_direction;
        #region old member valiable
        //public Dictionary<string, int> depthDictionary; // ステージごとのコードのdepthを入れる(おそらく途中から再開するため)
        /// <summary>
        /// 無限ループ阻止用措置ただしendの直前がfor,whileならエラーを吐けば不要
        /// </summary>
        //public bool endlessFlag; // 「ずっと」コマンドの中にいて、動作コマンド（前に進む、左を向く、右を向く、回復）が行われていない状態であるかどうか
        //public int depth;
        //public bool canMoveNextCode;  // 同フレーム内で次の行も実行していいかどうか. for・if・end の行を実行した時に true にして使う.
        //public bool canMoveEnemy=false; // コード実行時のフレーム処理で2フレームに1回だけエネミーが動くようにする
        //public int desiredMP; //　コマンドライン行数の目標値 
        //public int TeleporterPairId; // テレポート時のペアID
        //private Teleporter TeleportDestination; // テレポート先のテレポートマット

        #endregion
        #endregion
        public GameForm(Selectstage ss)
        {
            InitializeComponent();
            selectStage = ss;
            _graphicsBack = Graphics.FromImage(tableLayoutPanel1.BackgroundImage);
            _fps = 10;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty |
                BindingFlags.Instance | BindingFlags.NonPublic, null, backPictureBox, new object[] { true });
            
            // Set foreground graphics
            backPictureBox.Image = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsFore = Graphics.FromImage(backPictureBox.Image);
            _graphicsFore.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            _graphicsFore.Clear(Color.Transparent);

            // Set background graphics
            backPictureBox.BackgroundImage = new Bitmap(backPictureBox.Width, backPictureBox.Height);
            _graphicsBack = Graphics.FromImage(backPictureBox.BackgroundImage);
            _graphicsBack.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            _graphicsBack.Clear(Color.FromArgb(255, 181, 229, 29));

            globalTimer.Interval = (int)(1000 / (double)_fps);
            codeTimer.Interval = 333;
            _initialize(stageName);
            initialCellHeight = CellHeight;
            initialCellWidth = CellWidth;

            this.Hide();

        }
   
        public void _initialize(string fieldName)
        {
            // Read field from "{fieldName}.json"
            _field = ReadFieldJson($"{fieldName}");
            codeListBox.Items.Clear();
            currentStage.Text =fieldName;
            _initial_player_position = new List<int> { _field.Player.X, _field.Player.Y };
            _initial_player_direction = _field.Player.Direction;
            //_initial_enemy_position = new List<List<int>> { };
            foreach (var enemy in _field.Enemies)
            {
                var tmp = new List<int>{enemy.X, enemy.Y};
                //_initial_enemy_position.Add(tmp);
            }
            _graphicsBack.Clear(Color.FromArgb(255, 181, 229, 29));
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && !obj.CanMove) obj.Draw(_graphicsBack, initialCellWidth, initialCellHeight);
            }
            globalTimer.Start();
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
                myAssembly.GetManifestResourceStream("unilab2019.Fields." + name + ".json"),
                    Encoding.GetEncoding("utf-8"));
            var input = sr.ReadToEnd();
            sr.Close();

            var deserialized = JsonConvert.DeserializeObject<Field>(
                input, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            return deserialized;
        }
        #endregion

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            _draw();

        }
        private void _update()
        {
            foreach (var enemy in _field.Enemies)
            {
                if (_field.Player.Intersect(enemy)&&_field.Player.HP==0)
                {
                    codeTimer.Stop();
                    _initialize(stageName);
                    codeTimer.Stop();
                }
                else if(_field.Player.Intersect(enemy))
                {
                    _field.Player.HP--;
                }
            }
            foreach (var coin in _field.Coins)
            {
                if (_field.Player.Intersect(coin) && coin.IsAlive)
                {
                    _field.Player.Coins++;
                    coin.IsAlive = false;
                }
            }
            foreach (var oneup in _field.Oneups)
            {
                if (_field.Player.Intersect(oneup) && oneup.IsAlive)
                {
                    _field.Player.HP++;
                    oneup.IsAlive = false;
                }
            }
            // ゴールに着いたらタイマーを止める
            if (_field.Player.Intersect(_field.Goal))
            {
                codeTimer.Stop();
                //globalTimer.Stop();
                MessageBox.Show("ゴール！");

                var stage_table = new Dictionary<string, int>();
                stage_table.Add("stage1", calc_score());
                int score_result = stage_table.Count;
            }
        }
        private void _draw()
        {
            _graphicsFore.Clear(Color.Transparent);
            
            
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && obj.CanMove && obj.IsAlive) obj.Draw(_graphicsFore, initialCellWidth, initialCellHeight);

            }
            Refresh();
            coinCount.Text = $"コイン数:{_field.Player.Coins}";
            oneUpCount.Text = $"残機: {_field.Player.HP}";
            numOfLines.Text = $"行数: {codeListBox.Items.Count}";
            countTime.Text = $"時間: {_field.Player.Pedometer}";
        }

        private void _reset()
        {
            countEnemy = 0;
            _field.Player.X = _initial_player_position[0];
            _field.Player.Y = _initial_player_position[1];
            _field.Player.Direction = _initial_player_direction;
            _field.Player.Coins = 0;
            _field.Player.HP = 1;
            _field.Player.Pedometer = 0;
            codeTimer.Stop();
            foreach (var enemy in _field.Enemies)
            {
                var enemyAllRouteCount = enemy.MoveRoute.Count();//敵が繰り返すルートを一周するまでの移動数
                if (enemyAllRouteCount > 1)
                {
                    enemy.X = enemy.MoveRoute[enemyAllRouteCount - 2]["X"];
                    enemy.Y = enemy.MoveRoute[enemyAllRouteCount - 2]["Y"];
                }
                enemy.X = enemy.MoveRoute[enemyAllRouteCount - 1]["X"];
                enemy.Y = enemy.MoveRoute[enemyAllRouteCount - 1]["Y"];
            }
            foreach (var coin in _field.Coins)
            {
                coin.IsAlive = true;
            }
            foreach (var oneup in _field.Oneups)
            {
                oneup.IsAlive = true;
            }
        }

        public int calc_score()
        {
            int score_Result = 0;
            score_Result = 100 + (_field.Player.Coins) * 10 - _field.Player.HP - (codeListBox.Items.Count) * 2;
            return score_Result;
        }
        
        private void TextboxCaretControl(object sender, MouseEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        #region button_event
        //{}を含む部分はindentは増加しているが、codelistboxには反映させない。
        //
        //例
        //              indent
        //前に進む　　　0
        //もし {        1
        //    前に進む  1
        //}             1
        //前に進む      0
        //
        //選択されていなければindentは必ず0なので、本体の初期化部分が対応する

        private void GoForwardBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.Forward
            };
            if (selected == -1)
            {
                //選択されていないとき
                code.Add(tmp);
                codeListBox.Items.Add("前に進む");
            }
            else
            {
                if (selected != 0) tmp.Indent = code[selected-1].Indent;
                string indent_string = new string(' ', 2 * tmp.Indent);
                code.Insert(selected,tmp);
                codeListBox.Items.Insert(selected,indent_string+"前に進む");
            }
        }

        private void TurnLeftBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.TurnLeft
            };
            if (selected == -1)
            {
                //選択されていないとき
                code.Add(tmp);
                codeListBox.Items.Add("左を向く");
            }
            else
            {
                if (selected != 0) tmp.Indent = code[selected-1].Indent;
                string indent_string = new string(' ', 2 * tmp.Indent);
                code.Insert(selected, tmp);
                codeListBox.Items.Insert(selected, indent_string+"左を向く");
            }
        }

        private void TurnRightBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            Code tmp = new Code();
            tmp.Instruction = Types.Instruction.TurnRight;
            if (selected == -1)
            {
                //選択されていないとき
                code.Add(tmp);
                codeListBox.Items.Add("右を向く");
            }
            else
            {
                if (selected != 0) tmp.Indent = code[selected-1].Indent;
                string indent_string = new string(' ', 2 * tmp.Indent);
                code.Insert(selected, tmp);
                codeListBox.Items.Insert(selected, indent_string+"右を向く");

            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.Stop
            };
            if (selected == -1)
            {
                //選択されていないとき
                code.Add(tmp);
                codeListBox.Items.Add("止まる");
            }
            else
            {
                if (selected != 0) tmp.Indent = code[selected-1].Indent;
                string indent_string = new string(' ', 2 * tmp.Indent);
                code.Insert(selected, tmp);
                codeListBox.Items.Insert(selected, indent_string+"止まる");

            }
        }
        private void IfBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            bool add_flag = true;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.IfCode,
                Indent=1
            };
            Code end = new Code
            {
                Instruction = Types.Instruction.End,
                Indent=1
            };
            string dir="";
            string obj="";
            try
            {
                dir = comboBox1.SelectedItem.ToString();
                obj = comboBox2.SelectedItem.ToString();
            }
            catch
            {

            }
            //Direction設定
            switch (dir)
            {
                case "前":
                    tmp.Direction = Types.Direction.Forward;
                    break;
                case "左":
                    tmp.Direction = Types.Direction.Left;
                    break;
                case "右":
                    tmp.Direction = Types.Direction.Right;
                    break;
                case "後ろ":
                    tmp.Direction = Types.Direction.Backward;
                    break;
                default:
                    exeCodeStack.Clear();
                    MessageBox.Show("方向が変だよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    add_flag = false;
                    break;

            }
            //Object設定
            switch (obj)
            {
                case "壁":
                    tmp.Obj = Types.Obj.Wall;
                    break;
                case "敵":
                    tmp.Obj = Types.Obj.Enemy;
                    break;
                case "道":
                    tmp.Obj = Types.Obj.Road;
                    break;
                default:
                    exeCodeStack.Clear();
                    MessageBox.Show("対象が変だよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    add_flag = false;
                    break;

            }
            if (add_flag)
            {
                if (selected == -1)
                {
                    //選択されていないとき
                    code.Add(tmp);
                    code.Add(end);
                    codeListBox.Items.Add($"もし{dir}が{obj}なら{{");
                    codeListBox.Items.Add("}");
                    codeListBox.SelectedIndex=codeListBox.Items.Count-1;
                }
                else
                {
                    if (selected != 0) tmp.Indent = code[selected-1].Indent + 1;
                    if (selected != 0) end.Indent = code[selected-1].Indent + 1;
                    string indent_string = new string(' ', 2 * (tmp.Indent-1));
                    code.Insert(selected, tmp);
                    code.Insert(selected + 1, end);
                    codeListBox.Items.Insert(selected,indent_string+$"もし{dir}が{obj}なら{{");
                    codeListBox.Items.Insert(selected+1,indent_string+"}");
                    codeListBox.SelectedIndex = selected + 1;

                }
            }

        }

        private void ForBtn_Click(object sender, EventArgs e)
        {
            bool add_flag = true;
            var selected = codeListBox.SelectedIndex;
            int num=0;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.ForCode,
                Indent=1
            };
            Code end = new Code
            {
                Instruction = Types.Instruction.End,
                Indent=1
            };
            try
            {
                num= (int)numericUpDown1.Value;
                tmp.Repeat_num = num;
            }
            catch
            {
                exeCodeStack.Clear();
                MessageBox.Show("変な値を入れないで！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                add_flag = false;
            }
            if (add_flag)
            {
                if (selected == -1)
                {
                    //選択されていないとき
                    code.Add(tmp);
                    code.Add(end);
                    codeListBox.Items.Add($"{num}回繰り返す{{");
                    codeListBox.Items.Add("}");
                    codeListBox.SelectedIndex = codeListBox.Items.Count - 1;
                }
                else
                {
                    tmp.Indent = code[selected].Indent + 1;
                    end.Indent = code[selected].Indent + 1;
                    code.Insert(selected, tmp);
                    code.Insert(selected + 1, end);
                    string indent_string = new string(' ', 2 * (tmp.Indent-1));
                    codeListBox.Items.Insert(selected,indent_string+$"{num}回繰り返す{{");
                    codeListBox.Items.Insert(selected+1,indent_string+"}");
                    codeListBox.SelectedIndex = selected + 1;

                }
            }
        }

        private void WhileBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            Code tmp = new Code
            {
                Instruction = Types.Instruction.WhileCode,
                Indent=1
            };
            Code end = new Code
            {
                Instruction = Types.Instruction.End,
                Indent=1
            };
            if (selected == -1)
            {
                //選択されていないとき
                code.Add(tmp);
                code.Add(end);
                codeListBox.Items.Add("ずっと{");
                codeListBox.Items.Add("}");
                codeListBox.SelectedIndex = codeListBox.Items.Count - 1;
            }
            else
            {
                tmp.Indent = code[selected].Indent + 1;
                end.Indent = code[selected].Indent + 1;
                code.Insert(selected, tmp);
                code.Insert(selected + 1, end);
                string indent_string = new string(' ', 2 * (tmp.Indent-1));
                codeListBox.Items.Insert(selected,indent_string+"ずっと{");
                codeListBox.Items.Insert(selected+1,indent_string+"}");
                codeListBox.SelectedIndex=selected+1;
            }
        }
        
        /// <summary>
        /// 実行ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BackPictureBox_Click(object sender, EventArgs e)
        {
            codeListBox.SelectedIndex = -1;
        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            codeListBox.SelectedIndex = -1;
        }
        #endregion

        private void CodeTimer_Tick_1(object sender, EventArgs e)
        {
            canMoveNextCode = true;
            while (exeCodeStack.Count > 0 && canMoveNextCode == true) exeCodeStack.Peek().MoveNext();
            if (exeCodeStack.Count == 0) codeTimer.Stop();
            else
            {

                foreach (var enemy in _field.Enemies)
                {
                    var enemyAllRouteCount = enemy.MoveRoute.Count();//敵が繰り返すルートを一周するまでの移動数
                    enemy.X = enemy.MoveRoute[countEnemy % enemyAllRouteCount]["X"];
                    enemy.Y = enemy.MoveRoute[countEnemy % enemyAllRouteCount]["Y"];
                }
                countEnemy++;
                if (IsTeleporter(_field.Player.X, _field.Player.Y))
                {
                    TeleporterPairId = _field.Teleporters.Find(t => t.X == _field.Player.X && t.Y == _field.Player.Y).PairId;
                    TeleportDestination = _field.Teleporters.Find(t => t.PairId == TeleporterPairId && (t.X != _field.Player.X || t.Y != _field.Player.Y));
                    _field.Player.X = TeleportDestination.X;
                    _field.Player.Y = TeleportDestination.Y;
                    _field.Player.Direction = TeleportDestination.Direction;
                    _field.Player.Pedometer++;
                }

                if (_field.Player.HP <= 0)
                {
                    exeCodeStack.Clear();
                    MessageBox.Show("体力がなくなっちゃった！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            _update();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            _reset();
            exeCodeStack.Clear();
            exeCodeStack.Push(CarryOutScript(code));
            codeTimer.Start();
        }
        private void DeleteAllBtn_Click(object sender, EventArgs e)
        {
            code.Clear();
            codeListBox.Items.Clear();
            //codeTimer.Stop();

        }
        private void DeleteOneLineBtn_Click(object sender, EventArgs e)
        {
            var selected = codeListBox.SelectedIndex;
            //選択されていないとき
            if (selected == -1)
            {
                int lastIndex = codeListBox.Items.Count - 1;
                //もし最後の行が"}"のときは削除しない
                if ((string)codeListBox.Items[lastIndex] == "}") { }
                else
                {
                    code.RemoveAt(lastIndex);
                    codeListBox.Items.RemoveAt(lastIndex);
                }
            }
            else
            {
                //閉じ括弧が選択されているときは何もしない
                if (code[selected].Instruction == Types.Instruction.End) { }
                //始まり括弧の行が選択されているときは、括弧閉じも同時に削除,中身のインデント調整
                else if (codeListBox.Text.EndsWith("{"))
                {
                    int parenthesesIndex = -1;
                    code.RemoveAt(selected);
                    //閉じ括弧探す
                    for (int i = selected; i < code.Count; i++)
                    {
                        if (code[i].Instruction == Types.Instruction.End)
                        {
                            parenthesesIndex = i;
                            break;
                        }
                        else
                        {
                            code[i].Indent--;
                        }
                    }
                    code.RemoveAt(parenthesesIndex);

                    codeListBox.Items.RemoveAt(selected);
                    while (true)
                    {
                        //閉じ括弧だったら、削除
                        if ((string)codeListBox.Items[selected] == "}")
                        {
                            codeListBox.Items.RemoveAt(selected);
                            break;
                        }
                        //括弧の中身だったら、インデント一つ減らす
                        else
                        {
                            var line = (string)codeListBox.Items[selected];
                            line = line.Remove(0, 2);
                            codeListBox.Items.RemoveAt(selected);
                            codeListBox.Items.Insert(selected, line);
                        }
                        selected++;
                    }
                }
                else
                {
                    code.RemoveAt(selected);
                    codeListBox.Items.RemoveAt(selected);
                }
            }
        }
        #region スクリプト実行
        //

        ////コードを実行
        private IEnumerator<Code> CarryOutScript(List<Code> code)
        {
           
            int a = 1;

            for (int i = 0; i < code.Count(); i += a)
            {
                a = 1;
                switch (code[i].Instruction)
                {
                    case Types.Instruction.Forward:
                        if (IsWall(_field.Player.ForwardX(), _field.Player.ForwardY()))
                        {
                            exeCodeStack.Clear();
                            MessageBox.Show("前は壁だよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //codeTimer.Stop();
                            //globalTimer.Stop();
                        }
                        else
                        {
                            _field.Player.Pedometer++;
                            _field.Player.Move();
                        }
                        canMoveNextCode = false;
                        break;

                    case Types.Instruction.TurnRight:
                        _field.Player.Pedometer++;
                        _field.Player.TurnRight();
                        canMoveNextCode = false;
                        break;

                    case Types.Instruction.TurnLeft:
                        _field.Player.Pedometer++;
                        _field.Player.TurnLeft();
                        canMoveNextCode = false;
                        break;

                    case Types.Instruction.Stop:
                        _field.Player.Pedometer++;
                        canMoveNextCode = false;
                        break;

                    case Types.Instruction.IfCode:
                        //endの行数を格納する変数
                        int if_sub_indent = 0;

                        //if文のendを取得
                        for (int k = i; k < code.Count(); k++)
                        {
                            if (code[k].Instruction == Types.Instruction.End && code[i].Indent == code[k].Indent)
                            {
                                if_sub_indent = k;
                                break;
                            }
                        }
                        //中身の部分だけ一時的に取り出すcodeリストを作成
                        List<Code> if_subcode = new List<Code>();
                        for (int j = i + 1; j < if_sub_indent; j++)
                        {
                            if_subcode.Add(code[j]);
                        }
                        //ここまでforの処理と同じ
                        
                        //壁に関する条件分岐
                        //もし前が壁なら
                        if (code[i].Obj == Types.Obj.Wall && code[i].Direction == Types.Direction.Forward)
                        {
                            if (IsWall(_field.Player.ForwardX(), _field.Player.ForwardY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }
                        }


                        //もし後ろが壁なら
                        if (code[i].Obj == Types.Obj.Wall && code[i].Direction == Types.Direction.Backward)
                        {
                            if (IsWall(_field.Player.BackX(), _field.Player.BackY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし右が壁なら
                        if (code[i].Obj == Types.Obj.Wall && code[i].Direction == Types.Direction.Right)
                        {
                            if (IsWall(_field.Player.RightX(), _field.Player.RightY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし左が壁なら
                        if (code[i].Obj == Types.Obj.Wall && code[i].Direction == Types.Direction.Left)
                        {
                            if (IsWall(_field.Player.LeftX(), _field.Player.LeftY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //敵に関する条件分岐
                        //もし前が敵なら
                        if (code[i].Obj == Types.Obj.Enemy && code[i].Direction == Types.Direction.Forward)
                        {
                            if (IsEnemy(_field.Player.ForwardX(), _field.Player.ForwardY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし後ろが敵なら
                        if (code[i].Obj == Types.Obj.Enemy && code[i].Direction == Types.Direction.Backward)
                        {
                            if (IsEnemy(_field.Player.BackX(), _field.Player.BackY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし右が敵なら
                        if (code[i].Obj == Types.Obj.Enemy && code[i].Direction == Types.Direction.Right)
                        {
                            if (IsEnemy(_field.Player.RightX(), _field.Player.RightY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし左が敵なら
                        if (code[i].Obj == Types.Obj.Enemy && code[i].Direction == Types.Direction.Left)
                        {
                            if (IsEnemy(_field.Player.LeftX(), _field.Player.LeftY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //道に関する条件分岐
                        //もし前が道なら
                        if (code[i].Obj == Types.Obj.Road && code[i].Direction == Types.Direction.Forward)
                        {
                            if (IsRoad(_field.Player.ForwardX(), _field.Player.ForwardY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }


                        //もし後ろが道なら
                        if (code[i].Obj == Types.Obj.Road && code[i].Direction == Types.Direction.Backward)
                        {
                            if (IsRoad(_field.Player.BackX(), _field.Player.BackY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }

                        //もし右が道なら
                        if (code[i].Obj == Types.Obj.Road && code[i].Direction == Types.Direction.Right)
                        {
                            if (IsRoad(_field.Player.RightX(), _field.Player.RightY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }
                            

                        }

                        //もし左が道なら
                        if (code[i].Obj == Types.Obj.Road && code[i].Direction == Types.Direction.Left)
                        {
                            if (IsRoad(_field.Player.LeftX(), _field.Player.LeftY()))
                            {
                                exeCodeStack.Push(CarryOutScript(if_subcode));
                                canMoveNextCode = true;
                            }

                        }
                        i+=if_subcode.Count+1;//読まなかった分・読んでpushした分を飛ばす
                        a = 1;
                        break;

                    case Types.Instruction.ForCode:

                        //for文の最初の行を格納する変数
                        int for_sub_indent_start = i;
                        //endの行数を格納する変数
                        int for_sub_indent_end = 0;
                        
                        //for文のendを取得
                        for (int k = i; k < code.Count();k++)
                        {
                            if (code[k].Instruction == Types.Instruction.End && code[i].Indent == code[k].Indent)
                            {
                                for_sub_indent_end = k;
                                break;
                            }
                        }
                        //中身の部分だけ一時的に取り出すcodeリストを作成
                        List<Code> for_subcode = new List<Code>();
                        for (int j = i+1; j < for_sub_indent_end; j++)
                        {
                            for_subcode.Add(code[j]);
                        }

                        //中身のコードに対してスクリプト関数を実行
                        for (int m = 0; m < code[i].Repeat_num; m++)
                        {
                           exeCodeStack.Push(CarryOutScript(for_subcode));
                        }
                        a = for_sub_indent_end - for_sub_indent_start;
                        canMoveNextCode = true;
                        break;

                    case Types.Instruction.WhileCode:
                        //endの行数を格納する変数
                        int while_sub_indent = 0;

                        //while文のendを取得
                        for (int k = i; k < code.Count(); k++)
                        {
                            if (code[k].Instruction == Types.Instruction.End && code[i].Indent == code[k].Indent)
                            {
                                while_sub_indent = k;
                                break;
                            }
                        }
                        
                        //while全体を一時的に取り出すcodeリストを作成
                        List<Code> while_subcode = new List<Code>();
                        for (int j = i; j <= while_sub_indent; j++)
                        {
                            while_subcode.Add(code[j]);
                        }

                        //whileの中身を一時的に取り出すcodeリストを作成
                        List<Code> while_subcode_2 = new List<Code>();
                        for (int j = i+ 1; j < while_sub_indent; j++)
                        {
                            while_subcode_2.Add(code[j]);
                        }

                        //checkcodeをかける（無限ループの判定）
                        if(CheckCode(while_subcode)&& CheckCode(while_subcode_2))
                        {
                            exeCodeStack.Push(CarryOutScript(while_subcode));
                            exeCodeStack.Push(CarryOutScript(while_subcode_2));
                        }
                        canMoveNextCode = true;
                        break;

                    default:
                        break;
                }
                yield return null;
            }
            exeCodeStack.Pop();
            yield break;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectStage.Show();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            _reset();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }




        //// コードをチェック
        //// while文を使ったときに無限ループするかどうかを判定
        private bool CheckCode(List<Code> code)
        {
            if (code[0].Instruction == Types.Instruction.WhileCode &&  code[1].Instruction == Types.Instruction.End)
            {
                exeCodeStack.Clear();
                MessageBox.Show("無限ループしてしまうよ！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTimer.Stop();
                return false;
                //globalTimer.Stop();
            }
            return true;

        }

        #endregion
    }
    
}
