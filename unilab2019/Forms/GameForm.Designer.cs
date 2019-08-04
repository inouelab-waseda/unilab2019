namespace unilab2019.Forms
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button ifBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.currentStage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.forBtn = new System.Windows.Forms.Button();
            this.whileBtn = new System.Windows.Forms.Button();
            this.turnRightBtn = new System.Windows.Forms.Button();
            this.turnLeftBtn = new System.Windows.Forms.Button();
            this.goForwardBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.deleteOneBtn = new System.Windows.Forms.Button();
            this.deleteAllBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.backPictureBox = new System.Windows.Forms.PictureBox();
            this.numOfLines = new System.Windows.Forms.TextBox();
            this.countTime = new System.Windows.Forms.TextBox();
            this.oneUpCount = new System.Windows.Forms.TextBox();
            this.coinCount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.codeTimer = new System.Windows.Forms.Timer(this.components);
            ifBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ifBtn
            // 
            ifBtn.AutoSize = true;
            ifBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ifBtn.BackgroundImage = global::unilab2019.Properties.Resources.もし1;
            ifBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ifBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            ifBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ifBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            ifBtn.Location = new System.Drawing.Point(0, 0);
            ifBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ifBtn.Name = "ifBtn";
            ifBtn.Size = new System.Drawing.Size(140, 52);
            ifBtn.TabIndex = 2;
            ifBtn.Text = "　　　";
            ifBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::unilab2019.Properties.Resources.Wall1;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.594613F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.79126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.181753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.181753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.098463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.181753F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.126773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.052362F));
            this.tableLayoutPanel1.Controls.Add(this.codeListBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.currentStage, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.whileBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.turnRightBtn, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.turnLeftBtn, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.goForwardBtn, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.deleteOneBtn, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.deleteAllBtn, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.resetBtn, 7, 10);
            this.tableLayoutPanel1.Controls.Add(this.backPictureBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.numOfLines, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.countTime, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.oneUpCount, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.coinCount, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.245989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.663101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.235294F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.723277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.723277F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.81618F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.350407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.350407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.350407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.384706F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.403002F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.360518F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.258889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1027, 651);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // codeListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.codeListBox, 4);
            this.codeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 15;
            this.codeListBox.Location = new System.Drawing.Point(676, 187);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(8, 14, 20, 4);
            this.codeListBox.Name = "codeListBox";
            this.tableLayoutPanel1.SetRowSpan(this.codeListBox, 6);
            this.codeListBox.Size = new System.Drawing.Size(212, 350);
            this.codeListBox.TabIndex = 16;
            // 
            // currentStage
            // 
            this.currentStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentStage.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currentStage.Location = new System.Drawing.Point(39, 38);
            this.currentStage.Margin = new System.Windows.Forms.Padding(3, 24, 43, 4);
            this.currentStage.Name = "currentStage";
            this.currentStage.ReadOnly = true;
            this.currentStage.Size = new System.Drawing.Size(270, 31);
            this.currentStage.TabIndex = 12;
            this.currentStage.TabStop = false;
            this.currentStage.Text = "ステージ";
            this.currentStage.Click += new System.EventHandler(this.currentStage_caret_control);
            this.currentStage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            this.currentStage.MouseEnter += new System.EventHandler(this.textboxCursorControl);
            this.currentStage.MouseLeave += new System.EventHandler(this.textboxCursorControl);
            this.currentStage.MouseHover += new System.EventHandler(this.textboxCursorControl);
            this.currentStage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textboxCursorControl);
            this.currentStage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(ifBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(671, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 52);
            this.panel2.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "壁",
            "敵",
            "道"});
            this.comboBox2.Location = new System.Drawing.Point(71, 30);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(23, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "前",
            "後ろ",
            "右",
            "左"});
            this.comboBox1.Location = new System.Drawing.Point(7, 29);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(25, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.forBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(671, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 49);
            this.panel3.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.Location = new System.Drawing.Point(105, 15);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forBtn
            // 
            this.forBtn.BackgroundImage = global::unilab2019.Properties.Resources.繰り返し1;
            this.forBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forBtn.Location = new System.Drawing.Point(0, 0);
            this.forBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(140, 49);
            this.forBtn.TabIndex = 1;
            this.forBtn.Text = "　　\r\n";
            this.forBtn.UseVisualStyleBackColor = true;
            this.forBtn.Click += new System.EventHandler(this.ForBtn_Click);
            // 
            // whileBtn
            // 
            this.whileBtn.BackgroundImage = global::unilab2019.Properties.Resources.ずっと1;
            this.whileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.whileBtn, 2);
            this.whileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.whileBtn.Location = new System.Drawing.Point(671, 129);
            this.whileBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.whileBtn.Name = "whileBtn";
            this.whileBtn.Size = new System.Drawing.Size(140, 44);
            this.whileBtn.TabIndex = 0;
            this.whileBtn.UseVisualStyleBackColor = true;
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.BackColor = System.Drawing.Color.Lime;
            this.turnRightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnRightBtn.Location = new System.Drawing.Point(911, 74);
            this.turnRightBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(67, 45);
            this.turnRightBtn.TabIndex = 6;
            this.turnRightBtn.Text = "右を向く";
            this.turnRightBtn.UseVisualStyleBackColor = false;
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.BackColor = System.Drawing.Color.Lime;
            this.turnLeftBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnLeftBtn.Location = new System.Drawing.Point(838, 74);
            this.turnLeftBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(67, 45);
            this.turnLeftBtn.TabIndex = 5;
            this.turnLeftBtn.Text = "左を向く";
            this.turnLeftBtn.UseVisualStyleBackColor = false;
            // 
            // goForwardBtn
            // 
            this.goForwardBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.tableLayoutPanel1.SetColumnSpan(this.goForwardBtn, 2);
            this.goForwardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goForwardBtn.Location = new System.Drawing.Point(868, 18);
            this.goForwardBtn.Margin = new System.Windows.Forms.Padding(33, 4, 33, 4);
            this.goForwardBtn.Name = "goForwardBtn";
            this.goForwardBtn.Size = new System.Drawing.Size(80, 48);
            this.goForwardBtn.TabIndex = 4;
            this.goForwardBtn.Text = "前に進む";
            this.goForwardBtn.UseVisualStyleBackColor = false;
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.SetColumnSpan(this.stopBtn, 2);
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Location = new System.Drawing.Point(868, 127);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(33, 4, 33, 4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(80, 42);
            this.stopBtn.TabIndex = 22;
            this.stopBtn.Text = "止まる";
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // deleteOneBtn
            // 
            this.deleteOneBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteOneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOneBtn.ForeColor = System.Drawing.Color.Yellow;
            this.deleteOneBtn.Location = new System.Drawing.Point(911, 356);
            this.deleteOneBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteOneBtn.Name = "deleteOneBtn";
            this.deleteOneBtn.Size = new System.Drawing.Size(67, 39);
            this.deleteOneBtn.TabIndex = 7;
            this.deleteOneBtn.Text = "1つ削除";
            this.deleteOneBtn.UseVisualStyleBackColor = false;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.BackColor = System.Drawing.Color.Black;
            this.deleteAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAllBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllBtn.Location = new System.Drawing.Point(911, 403);
            this.deleteAllBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(67, 39);
            this.deleteAllBtn.TabIndex = 8;
            this.deleteAllBtn.Text = "全て削除";
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Brown;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(911, 460);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 14, 3, 14);
            this.startBtn.Name = "startBtn";
            this.tableLayoutPanel1.SetRowSpan(this.startBtn, 2);
            this.startBtn.Size = new System.Drawing.Size(67, 67);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "実行！";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Location = new System.Drawing.Point(911, 545);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(67, 40);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "プレーヤー\r\nをリセット";
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // backPictureBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.backPictureBox, 2);
            this.backPictureBox.Location = new System.Drawing.Point(39, 127);
            this.backPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backPictureBox.Name = "backPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.backPictureBox, 8);
            this.backPictureBox.Size = new System.Drawing.Size(626, 458);
            this.backPictureBox.TabIndex = 27;
            this.backPictureBox.TabStop = false;
            // 
            // numOfLines
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numOfLines, 4);
            this.numOfLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOfLines.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfLines.Location = new System.Drawing.Point(676, 557);
            this.numOfLines.Margin = new System.Windows.Forms.Padding(8, 16, 20, 14);
            this.numOfLines.Name = "numOfLines";
            this.numOfLines.ReadOnly = true;
            this.numOfLines.Size = new System.Drawing.Size(212, 31);
            this.numOfLines.TabIndex = 15;
            this.numOfLines.TabStop = false;
            this.numOfLines.Text = "行数：";
            this.numOfLines.Click += new System.EventHandler(this.currentStage_caret_control);
            this.numOfLines.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            this.numOfLines.MouseEnter += new System.EventHandler(this.textboxCursorControl);
            this.numOfLines.MouseLeave += new System.EventHandler(this.textboxCursorControl);
            this.numOfLines.MouseHover += new System.EventHandler(this.textboxCursorControl);
            this.numOfLines.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textboxCursorControl);
            this.numOfLines.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            // 
            // countTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.countTime, 4);
            this.countTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTime.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countTime.Location = new System.Drawing.Point(676, 593);
            this.countTime.Margin = new System.Windows.Forms.Padding(8, 4, 20, 4);
            this.countTime.Name = "countTime";
            this.countTime.ReadOnly = true;
            this.countTime.Size = new System.Drawing.Size(212, 31);
            this.countTime.TabIndex = 28;
            this.countTime.TabStop = false;
            this.countTime.Text = "時間：";
            this.countTime.Click += new System.EventHandler(this.currentStage_caret_control);
            this.countTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            this.countTime.MouseEnter += new System.EventHandler(this.textboxCursorControl);
            this.countTime.MouseLeave += new System.EventHandler(this.textboxCursorControl);
            this.countTime.MouseHover += new System.EventHandler(this.textboxCursorControl);
            this.countTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textboxCursorControl);
            this.countTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            // 
            // oneUpCount
            // 
            this.oneUpCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneUpCount.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oneUpCount.Location = new System.Drawing.Point(395, 593);
            this.oneUpCount.Margin = new System.Windows.Forms.Padding(43, 4, 20, 4);
            this.oneUpCount.Name = "oneUpCount";
            this.oneUpCount.ReadOnly = true;
            this.oneUpCount.Size = new System.Drawing.Size(253, 31);
            this.oneUpCount.TabIndex = 14;
            this.oneUpCount.TabStop = false;
            this.oneUpCount.Text = "残機：";
            this.oneUpCount.Click += new System.EventHandler(this.currentStage_caret_control);
            this.oneUpCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            this.oneUpCount.MouseEnter += new System.EventHandler(this.textboxCursorControl);
            this.oneUpCount.MouseLeave += new System.EventHandler(this.textboxCursorControl);
            this.oneUpCount.MouseHover += new System.EventHandler(this.textboxCursorControl);
            this.oneUpCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textboxCursorControl);
            this.oneUpCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            // 
            // coinCount
            // 
            this.coinCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coinCount.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.coinCount.Location = new System.Drawing.Point(39, 593);
            this.coinCount.Margin = new System.Windows.Forms.Padding(3, 4, 43, 4);
            this.coinCount.Name = "coinCount";
            this.coinCount.ReadOnly = true;
            this.coinCount.Size = new System.Drawing.Size(270, 31);
            this.coinCount.TabIndex = 13;
            this.coinCount.TabStop = false;
            this.coinCount.Text = "コイン数：";
            this.coinCount.Click += new System.EventHandler(this.currentStage_caret_control);
            this.coinCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            this.coinCount.MouseEnter += new System.EventHandler(this.textboxCursorControl);
            this.coinCount.MouseLeave += new System.EventHandler(this.textboxCursorControl);
            this.coinCount.MouseHover += new System.EventHandler(this.textboxCursorControl);
            this.coinCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.textboxCursorControl);
            this.coinCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.currentStage_caret_control);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(39, 72);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button whileBtn;
        private System.Windows.Forms.Button forBtn;
        private System.Windows.Forms.Button goForwardBtn;
        private System.Windows.Forms.Button turnLeftBtn;
        private System.Windows.Forms.Button turnRightBtn;
        private System.Windows.Forms.Button deleteOneBtn;
        private System.Windows.Forms.Button deleteAllBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox currentStage;
        private System.Windows.Forms.TextBox oneUpCount;
        private System.Windows.Forms.TextBox numOfLines;
        private System.Windows.Forms.ListBox codeListBox;
        private System.Windows.Forms.TextBox coinCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox backPictureBox;
        private System.Windows.Forms.TextBox countTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.Timer codeTimer;
    }
}