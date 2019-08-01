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
using System.IO;
using Newtonsoft.Json;
using System.Collections;
using Unilab2019.Helpers;




namespace unilab2019.Forms
{
    public partial class Selectstage : Form
    {
        private Field _field;
        GameForm gameform;

        public Selectstage(GameForm gf)
        {
            InitializeComponent();
            gameform = gf;
        }

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

        public void _initialize(string fieldName)
        {
            _field = ReadFieldJson($"{fieldName}");
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && !obj.CanMove) obj.Draw();
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Selectstage_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Hide();
            //_initialize("stage6");
            gameform.Show();
        }
        //ステージ6のボタン

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage5");
            gameform.Show();
        }
        //ステージ5のボタン

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage1");
            gameform.Show();
        }
        //ステージ1のボタン

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage2");
            gameform.Show();
        }
        //ステージ2のボタン

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage3");
            gameform.Show();
        }
        //ステージ3のボタン

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage4");
            gameform.Show();
        }
        //ステージ4のボタン

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage7");
            gameform.Show();
        }
        //ステージ7のボタン

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage8");
            gameform.Show();
        }
        //ステージ8のボタン

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage9");
            gameform.Show();
        }
        //ステージ9のボタン

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            //_initialize("stage10");
            gameform.Show();
        }
        //ステージ10のボタン
    }
}
