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
        void TableLayoutPanel1_CellPaint(object sender,
    TableLayoutCellPaintEventArgs e)
        {
            if ((e.Column == 3 || e.Column == 4 || e.Column == 5) && (e.Row == 1 || e.Row == 2))
            {
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.CellBounds);
            }
        }

    }
}
