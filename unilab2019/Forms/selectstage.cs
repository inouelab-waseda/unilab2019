﻿using System;
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

        public Selectstage(GameForm gf)
        {
            InitializeComponent();
            gameForm = gf;
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
            gameForm._initialize("stage6");
            gameForm.Show();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage5");
            gameForm.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage1");
            gameForm.Show();
        }

        private void PictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage2");
            gameForm.Show();
        }

        private void PictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage3");
            gameForm.Show();
        }

        private void PictureBox4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage4");
            gameForm.Show();
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage7");
            gameForm.Show();
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage8");
            gameForm.Show();
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage9");
            gameForm.Show();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm._initialize("stage10");
            gameForm.Show();
        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
