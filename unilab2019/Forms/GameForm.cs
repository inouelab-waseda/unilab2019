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
    }
}
