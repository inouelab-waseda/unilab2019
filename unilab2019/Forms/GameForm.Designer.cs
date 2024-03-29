﻿namespace unilab2019.Forms
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
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.codeTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.codeListBox = new System.Windows.Forms.ListBox();
            this.currentStage = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            ifBtn.Margin = new System.Windows.Forms.Padding(2);
            ifBtn.Name = "ifBtn";
            ifBtn.Size = new System.Drawing.Size(341, 80);
            ifBtn.TabIndex = 2;
            ifBtn.Text = "　　　";
            ifBtn.UseVisualStyleBackColor = true;
            ifBtn.Click += new System.EventHandler(this.IfBtn_Click);
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // codeTimer
            // 
            this.codeTimer.Tick += new System.EventHandler(this.CodeTimer_Tick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::unilab2019.Properties.Resources.back;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.157444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.21512F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.01247F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.92931F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.106029F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.4677755F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.068607F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.276507F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.731809F));
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.059829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.863248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.641026F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.153846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.589744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.521368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.205129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.48718F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.239316F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.094017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.863248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.658119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1922, 1054);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TableLayoutPanel1_Click);
            // 
            // codeListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.codeListBox, 4);
            this.codeListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeListBox.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.codeListBox.FormattingEnabled = true;
            this.codeListBox.ItemHeight = 28;
            this.codeListBox.Location = new System.Drawing.Point(1131, 314);
            this.codeListBox.Margin = new System.Windows.Forms.Padding(10, 14, 25, 2);
            this.codeListBox.Name = "codeListBox";
            this.tableLayoutPanel1.SetRowSpan(this.codeListBox, 6);
            this.codeListBox.Size = new System.Drawing.Size(453, 472);
            this.codeListBox.TabIndex = 16;
            // 
            // currentStage
            // 
            this.currentStage.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentStage.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currentStage.Location = new System.Drawing.Point(120, 121);
            this.currentStage.Margin = new System.Windows.Forms.Padding(2, 26, 52, 2);
            this.currentStage.Name = "currentStage";
            this.currentStage.ReadOnly = true;
            this.currentStage.Size = new System.Drawing.Size(488, 35);
            this.currentStage.TabIndex = 12;
            this.currentStage.TabStop = false;
            this.currentStage.Text = "ステージ";
            this.currentStage.Click += new System.EventHandler(this.TextboxCaretControl);
            this.currentStage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            this.currentStage.MouseEnter += new System.EventHandler(this.TextboxCursorControl);
            this.currentStage.MouseLeave += new System.EventHandler(this.TextboxCursorControl);
            this.currentStage.MouseHover += new System.EventHandler(this.TextboxCursorControl);
            this.currentStage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextboxCursorControl);
            this.currentStage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(ifBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1123, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 80);
            this.panel2.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "前",
            "後ろ",
            "右",
            "左"});
            this.comboBox1.Location = new System.Drawing.Point(8, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 36);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "前";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "木",
            "てき",
            "道"});
            this.comboBox2.Location = new System.Drawing.Point(151, 38);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 36);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "てき";
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.forBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(1123, 179);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 57);
            this.panel3.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDown1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(211, 10);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 35);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forBtn
            // 
            this.forBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forBtn.BackgroundImage")));
            this.forBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forBtn.Location = new System.Drawing.Point(0, 0);
            this.forBtn.Margin = new System.Windows.Forms.Padding(2);
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(341, 57);
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
            this.whileBtn.Location = new System.Drawing.Point(1123, 246);
            this.whileBtn.Margin = new System.Windows.Forms.Padding(2, 10, 2, 0);
            this.whileBtn.Name = "whileBtn";
            this.whileBtn.Size = new System.Drawing.Size(341, 54);
            this.whileBtn.TabIndex = 0;
            this.whileBtn.UseVisualStyleBackColor = true;
            this.whileBtn.Click += new System.EventHandler(this.WhileBtn_Click);
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.BackColor = System.Drawing.Color.Lime;
            this.turnRightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnRightBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.turnRightBtn.Location = new System.Drawing.Point(1611, 179);
            this.turnRightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(135, 55);
            this.turnRightBtn.TabIndex = 6;
            this.turnRightBtn.Text = "右を向く";
            this.turnRightBtn.UseVisualStyleBackColor = false;
            this.turnRightBtn.Click += new System.EventHandler(this.TurnRightBtn_Click);
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.BackColor = System.Drawing.Color.Lime;
            this.turnLeftBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnLeftBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.turnLeftBtn.Location = new System.Drawing.Point(1476, 179);
            this.turnLeftBtn.Margin = new System.Windows.Forms.Padding(2);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(131, 55);
            this.turnLeftBtn.TabIndex = 5;
            this.turnLeftBtn.Text = "左を向く";
            this.turnLeftBtn.UseVisualStyleBackColor = false;
            this.turnLeftBtn.Click += new System.EventHandler(this.TurnLeftBtn_Click);
            // 
            // goForwardBtn
            // 
            this.goForwardBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.tableLayoutPanel1.SetColumnSpan(this.goForwardBtn, 2);
            this.goForwardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goForwardBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.goForwardBtn.Location = new System.Drawing.Point(1516, 97);
            this.goForwardBtn.Margin = new System.Windows.Forms.Padding(42, 2, 42, 2);
            this.goForwardBtn.Name = "goForwardBtn";
            this.goForwardBtn.Size = new System.Drawing.Size(190, 78);
            this.goForwardBtn.TabIndex = 4;
            this.goForwardBtn.Text = "前に進む";
            this.goForwardBtn.UseVisualStyleBackColor = false;
            this.goForwardBtn.Click += new System.EventHandler(this.GoForwardBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tableLayoutPanel1.SetColumnSpan(this.stopBtn, 2);
            this.stopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopBtn.Location = new System.Drawing.Point(1516, 238);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(42, 2, 42, 2);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(190, 60);
            this.stopBtn.TabIndex = 22;
            this.stopBtn.Text = "止まる";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // deleteOneBtn
            // 
            this.deleteOneBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteOneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOneBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteOneBtn.ForeColor = System.Drawing.Color.Yellow;
            this.deleteOneBtn.Location = new System.Drawing.Point(1611, 460);
            this.deleteOneBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteOneBtn.Name = "deleteOneBtn";
            this.deleteOneBtn.Size = new System.Drawing.Size(135, 75);
            this.deleteOneBtn.TabIndex = 7;
            this.deleteOneBtn.Text = "1つ消す";
            this.deleteOneBtn.UseVisualStyleBackColor = false;
            this.deleteOneBtn.Click += new System.EventHandler(this.DeleteOneLineBtn_Click);
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.BackColor = System.Drawing.Color.Black;
            this.deleteAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAllBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteAllBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllBtn.Location = new System.Drawing.Point(1611, 539);
            this.deleteAllBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(135, 82);
            this.deleteAllBtn.TabIndex = 8;
            this.deleteAllBtn.Text = "全部消す";
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            this.deleteAllBtn.Click += new System.EventHandler(this.DeleteAllBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Brown;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(1611, 637);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2, 14, 2, 14);
            this.startBtn.Name = "startBtn";
            this.tableLayoutPanel1.SetRowSpan(this.startBtn, 2);
            this.startBtn.Size = new System.Drawing.Size(135, 137);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "実行！";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetBtn.Location = new System.Drawing.Point(1611, 790);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.tableLayoutPanel1.SetRowSpan(this.resetBtn, 2);
            this.resetBtn.Size = new System.Drawing.Size(135, 152);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "プレーヤー\r\nをリセット";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // backPictureBox
            // 
            this.backPictureBox.BackgroundImage = global::unilab2019.Properties.Resources.background;
            this.backPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.backPictureBox, 2);
            this.backPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.backPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPictureBox.Location = new System.Drawing.Point(120, 238);
            this.backPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.backPictureBox.Name = "backPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.backPictureBox, 8);
            this.backPictureBox.Size = new System.Drawing.Size(999, 622);
            this.backPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPictureBox.TabIndex = 27;
            this.backPictureBox.TabStop = false;
            this.backPictureBox.Click += new System.EventHandler(this.BackPictureBox_Click);
            // 
            // numOfLines
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numOfLines, 4);
            this.numOfLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOfLines.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfLines.Location = new System.Drawing.Point(1131, 810);
            this.numOfLines.Margin = new System.Windows.Forms.Padding(10, 22, 25, 14);
            this.numOfLines.Name = "numOfLines";
            this.numOfLines.ReadOnly = true;
            this.numOfLines.Size = new System.Drawing.Size(453, 35);
            this.numOfLines.TabIndex = 15;
            this.numOfLines.TabStop = false;
            this.numOfLines.Text = "行数：";
            this.numOfLines.Click += new System.EventHandler(this.TextboxCaretControl);
            this.numOfLines.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            this.numOfLines.MouseEnter += new System.EventHandler(this.TextboxCursorControl);
            this.numOfLines.MouseLeave += new System.EventHandler(this.TextboxCursorControl);
            this.numOfLines.MouseHover += new System.EventHandler(this.TextboxCursorControl);
            this.numOfLines.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextboxCursorControl);
            this.numOfLines.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            // 
            // countTime
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.countTime, 4);
            this.countTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countTime.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.countTime.Location = new System.Drawing.Point(1131, 864);
            this.countTime.Margin = new System.Windows.Forms.Padding(10, 2, 25, 2);
            this.countTime.Name = "countTime";
            this.countTime.ReadOnly = true;
            this.countTime.Size = new System.Drawing.Size(453, 35);
            this.countTime.TabIndex = 28;
            this.countTime.TabStop = false;
            this.countTime.Text = "時間：";
            this.countTime.Click += new System.EventHandler(this.TextboxCaretControl);
            this.countTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            this.countTime.MouseEnter += new System.EventHandler(this.TextboxCursorControl);
            this.countTime.MouseLeave += new System.EventHandler(this.TextboxCursorControl);
            this.countTime.MouseHover += new System.EventHandler(this.TextboxCursorControl);
            this.countTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextboxCursorControl);
            this.countTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            // 
            // oneUpCount
            // 
            this.oneUpCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneUpCount.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oneUpCount.Location = new System.Drawing.Point(712, 864);
            this.oneUpCount.Margin = new System.Windows.Forms.Padding(52, 2, 25, 2);
            this.oneUpCount.Name = "oneUpCount";
            this.oneUpCount.ReadOnly = true;
            this.oneUpCount.Size = new System.Drawing.Size(384, 35);
            this.oneUpCount.TabIndex = 14;
            this.oneUpCount.TabStop = false;
            this.oneUpCount.Text = "残機：";
            this.oneUpCount.Click += new System.EventHandler(this.TextboxCaretControl);
            this.oneUpCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            this.oneUpCount.MouseEnter += new System.EventHandler(this.TextboxCursorControl);
            this.oneUpCount.MouseLeave += new System.EventHandler(this.TextboxCursorControl);
            this.oneUpCount.MouseHover += new System.EventHandler(this.TextboxCursorControl);
            this.oneUpCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextboxCursorControl);
            this.oneUpCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            // 
            // coinCount
            // 
            this.coinCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coinCount.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.coinCount.Location = new System.Drawing.Point(120, 864);
            this.coinCount.Margin = new System.Windows.Forms.Padding(2, 2, 52, 2);
            this.coinCount.Name = "coinCount";
            this.coinCount.ReadOnly = true;
            this.coinCount.Size = new System.Drawing.Size(488, 35);
            this.coinCount.TabIndex = 13;
            this.coinCount.TabStop = false;
            this.coinCount.Text = "コイン数：";
            this.coinCount.Click += new System.EventHandler(this.TextboxCaretControl);
            this.coinCount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            this.coinCount.MouseEnter += new System.EventHandler(this.TextboxCursorControl);
            this.coinCount.MouseLeave += new System.EventHandler(this.TextboxCursorControl);
            this.coinCount.MouseHover += new System.EventHandler(this.TextboxCursorControl);
            this.coinCount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TextboxCursorControl);
            this.coinCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextboxCaretControl);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::unilab2019.Properties.Resources.ステージ選択;
            this.pictureBox2.Location = new System.Drawing.Point(120, 179);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(538, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1054);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
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
        public System.Windows.Forms.TextBox currentStage;
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