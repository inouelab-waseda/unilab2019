using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unilab2019.Forms
{
    public partial class Selectstage : Form
    {
        GameForm gameForm;

        public Selectstage()
        {
            InitializeComponent();
            gameForm = new GameForm(this);
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
            gameForm._initialize("stage6");
            this.Hide();
            gameForm.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            gameForm._initialize("stage5");
            this.Hide();
            gameForm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            gameForm._initialize("stage1");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            gameForm._initialize("stage2");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            gameForm._initialize("stage3");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            gameForm._initialize("stage4");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage7");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage8");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage9");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage10");
            this.Hide();
            gameForm.Show();
        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e) {
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var score_stage1 = gameForm.calc_score();
            textBox1.Text = score_stage1.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            var score_stage2 = gameForm.calc_score();
            textBox1.Text = score_stage2.ToString();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            var score_stage3 = gameForm.calc_score();
            textBox1.Text = score_stage3.ToString();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            var score_stage4 = gameForm.calc_score();
            textBox1.Text = score_stage4.ToString();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            var score_stage5 = gameForm.calc_score();
            textBox1.Text = score_stage5.ToString();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            var score_stage6 = gameForm.calc_score();
            textBox1.Text = score_stage6.ToString();
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            var score_stage7 = gameForm.calc_score();
            textBox1.Text = score_stage7.ToString();
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            var score_stage8 = gameForm.calc_score();
            textBox1.Text = score_stage8.ToString();
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            var score_stage9 = gameForm.calc_score();
            textBox1.Text = score_stage9.ToString();
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            var score_stage10 = gameForm.calc_score();
            textBox1.Text = score_stage10.ToString();
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage11");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage12");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage13");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage14");
            this.Hide();
            gameForm.Show();
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            gameForm._initialize("stage15");
            this.Hide();
            gameForm.Show();
        }
    }
}
