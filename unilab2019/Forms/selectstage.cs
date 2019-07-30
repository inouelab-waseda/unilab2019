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
        public static UserControl00 ctr00;
        public static UserControl0 ctr0;
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;
        public static UserControl4 ctr4;
        public static UserControl5 ctr5;
        public static UserControl6 ctr6;
        public static UserControl7 ctr7;
        public static UserControl8 ctr8;
        public static UserControl9 ctr9;
        public static UserControl10 ctr10;
        //ホーム画面はctr00でゲーム起動時のみ出力
        //ステージ選択画面はctr0

        public Selectstage()
        {
            InitializeComponent();
            ctr00 = new UserControl00();
            ctr0 = new UserControl0();
            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            ctr3 = new UserControl3();
            ctr4 = new UserControl4();
            ctr5 = new UserControl5();
            ctr6 = new UserControl6();
            ctr7 = new UserControl7();
            ctr8 = new UserControl8();
            ctr9 = new UserControl9();
            ctr10 = new UserControl10();

            panel00.Controls.Add(ctr00);
            panel0.Controls.Add(ctr0);
            panel1.Controls.Add(ctr1);
            panel2.Controls.Add(ctr2);
            panel3.Controls.Add(ctr3);
            panel4.Controls.Add(ctr4);
            panel5.Controls.Add(ctr5);
            panel6.Controls.Add(ctr6);
            panel7.Controls.Add(ctr7);
            panel8.Controls.Add(ctr8);
            panel9.Controls.Add(ctr9);
            panel10.Controls.Add(ctr10);

            ctr00.Visible = true;
            ctr0.Visible = false;
            ctr1.Visible = false;
            ctr2.Visible = false;
            ctr3.Visible = false;
            ctr4.Visible = false;
            ctr5.Visible = false;
            ctr6.Visible = false;
            ctr7.Visible = false;
            ctr8.Visible = false;
            ctr9.Visible = false;
            ctr10.Visible = false;
            
        }
    }

    publlic partial class UserControl00 : UserControl1
    {
        public UserControl00()
        {
            InitializeComponent();
        }
        private void button00_Click(object sender, EventArgs e)
        {
            Selectstage.ctr00.Visible = false;
            Selectstage.ctr0.Visible = true;
        }
    }
    //ホーム画面

    publlic partial class UserControl0 : UserControl1
    {
        public UserControl0()
        {
            InitializeComponent();
        }
        private void button01_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr1.Visible = true;
        }
        private void button02_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr2.Visible = true;
        }
        private void button03_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr3.Visible = true;
        }
        private void button04_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr4.Visible = true;
        }
        private void button05_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr5.Visible = true;
        }
        private void button06_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr6.Visible = true;
        }
        private void button07_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr7.Visible = true;
        }
        private void button08_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr8.Visible = true;
        }
        private void button09_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr9.Visible = true;
        }
        private void button010_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = false;
            Selectstage.ctr10.Visible = true;
        }
    }
    //ステージ選択画面


    publlic partial class UserControl1 : UserControl1
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Load(object sender, EventArags e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr1.Visible = false;
        }
    }
    //ステージ1

    publlic partial class UserControl2 : UserControl1
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr2.Visible = false;
        }
    }
    //ステージ2

    publlic partial class UserControl3 : UserControl1
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr3.Visible = false;
        }
    }
    //ステージ3

    publlic partial class UserControl4 : UserControl1
    {
        public UserControl4()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr4.Visible = false;
        }
    }
    //ステージ4

    publlic partial class UserControl5 : UserControl1
    {
        public UserControl5()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr5.Visible = false;
        }
    }
    //ステージ5

    publlic partial class UserControl6 : UserControl1
    {
        public UserControl6()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr6.Visible = false;
        }
    }
    //ステージ6

    publlic partial class UserControl7 : UserControl1
    {
        public UserControl7()
        {
            InitializeComponent();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr7.Visible = false;
        }
    }
    //ステージ7

    publlic partial class UserControl8 : UserControl1
    {
        public UserControl8()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr8.Visible = false;
        }
    }
    //ステージ8

    publlic partial class UserControl9 : UserControl1
    {
        public UserControl9()
        {
            InitializeComponent();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr9.Visible = false;
        }
    }
    //ステージ9

    publlic partial class UserControl10 : UserControl1
    {
        public UserControl10()
        {
            InitializeComponent();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            Selectstage.ctr0.Visible = true;
            Selectstage.ctr10.Visible = false;
        }
    }
    //ステージ10
}
