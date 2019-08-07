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
        GameForm gameForm;
        Dictionary<string, int> stage_table = new Dictionary<string, int>();


        public AllStageClear(Selectstage ss, GameForm gf, Dictionary<string, int> st)
            {
                InitializeComponent();
                selectStage = ss;
                gameForm = gf;
                stage_table = st;
            }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
  
            selectStage.Show();
                      this.Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
