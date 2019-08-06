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
        public StageClear(Selectstage ss)
        {
            InitializeComponent();
            selectstage = ss;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            selectstage.Show();
            this.Hide();
        }
    }
}
