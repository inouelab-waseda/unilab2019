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
    public partial class StageClear : Form
    {
        Selectstage selectstage;
        GameForm gameForm;
        AllStageClear allstageClear;
        Dictionary<string, int> stage_table = new Dictionary<string, int>();


        public StageClear(Selectstage ss,GameForm gf, Dictionary<string, int> st)
        {
            InitializeComponent();
            selectstage = ss;
            gameForm = gf;
            stage_table = st;
            allstageClear = new AllStageClear(selectstage, gameForm, stage_table);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if(gameForm.currentStage.Text == "stage1")
            {
                selectstage.textBox1.Text = stage_table["stage1"].ToString();

            }
            if (gameForm.currentStage.Text == "stage2")
            {
                selectstage.textBox2.Text = stage_table["stage2"].ToString();

            }
            if (gameForm.currentStage.Text == "stage3")
            {
                selectstage.textBox3.Text = stage_table["stage3"].ToString();

            }
            if (gameForm.currentStage.Text == "stage4")
            {
                selectstage.textBox4.Text = stage_table["stage4"].ToString();

            }
            if (gameForm.currentStage.Text == "stage5")
            {
                selectstage.textBox5.Text = stage_table["stage5"].ToString();

            }
            if (gameForm.currentStage.Text == "stage6")
            {
                selectstage.textBox6.Text = stage_table["stage6"].ToString();

            }
            if (gameForm.currentStage.Text == "stage7")
            {
                selectstage.textBox7.Text = stage_table["stage7"].ToString();

            }
            if (gameForm.currentStage.Text == "stage8")
            {
                selectstage.textBox8.Text = stage_table["stage8"].ToString();

            }
            if (gameForm.currentStage.Text == "stage9")
            {
                selectstage.textBox9.Text = stage_table["stage9"].ToString();

            }
            if (gameForm.currentStage.Text == "stage10")
            {
                selectstage.textBox10.Text = stage_table["stage10"].ToString();

            }
            if (gameForm.currentStage.Text == "stage11")
            {
                selectstage.textBox12.Text = stage_table["stage11"].ToString();

            }
            if (gameForm.currentStage.Text == "stage12")
            {
                selectstage.textBox13.Text = stage_table["stage12"].ToString();

            }
            if (gameForm.currentStage.Text == "stage13")
            {
                selectstage.textBox14.Text = stage_table["stage13"].ToString();

            }
            if (gameForm.currentStage.Text == "stage14")
            {
                selectstage.textBox15.Text = stage_table["stage14"].ToString();

            }
            if (gameForm.currentStage.Text == "stage15")
            {
                selectstage.textBox16.Text = stage_table["stage15"].ToString();
            }
            if (stage_table.Values.Any(x => x == 0))
            {
                this.Hide();
                selectstage.Show();
                
            }
            else {
                this.Hide();
                allstageClear.Show();
                
            }
            
        }
        private void StageClear_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
    }
}
