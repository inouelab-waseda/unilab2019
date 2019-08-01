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
    public partial class GameForm : Form
    {

        public GameForm()
        {
            InitializeComponent();
        }

        private void currentStage_caret_control(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
            TextBox textbox = (TextBox)sender;
            textbox.Enabled = false;
            textbox.Enabled = true;
        }

        private void textboxCursorControl(object sender, EventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void textboxCursorControl(object sender, MouseEventArgs e)
        {
            if (Cursor.Current != Cursors.Default)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void currentStage_caret_control(object sender, MouseEventArgs e)
        {

        }

        private void ForBtn_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Selectstage selectstage = new Selectstage(this);
            this.Hide();
            selectstage.Show();
        }
    }
}
