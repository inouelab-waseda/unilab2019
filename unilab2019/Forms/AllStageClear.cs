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
    public partial class AllStageClear : Form
    {
        Selectstage selectStage;
        public AllStageClear()
        {
            selectStage = new Selectstage();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectStage.Show();
        }
    }
}
