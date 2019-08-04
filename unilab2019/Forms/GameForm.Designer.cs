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
            System.Windows.Forms.Button ifBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numOfLines = new System.Windows.Forms.TextBox();
            this.countTime = new System.Windows.Forms.TextBox();
            this.oneUpCount = new System.Windows.Forms.TextBox();
            this.coinCount = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentStage = new System.Windows.Forms.TextBox();
            ifBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            ifBtn.Location = new System.Drawing.Point(756, 20);
            ifBtn.Name = "ifBtn";
            this.tableLayoutPanel1.SetRowSpan(ifBtn, 2);
            ifBtn.Size = new System.Drawing.Size(53, 61);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.181754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.181754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.098463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.181754F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.126773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.052362F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.whileBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.turnRightBtn, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.turnLeftBtn, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.goForwardBtn, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.stopBtn, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.deleteOneBtn, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.deleteAllBtn, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.startBtn, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.resetBtn, 7, 11);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numOfLines, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.countTime, 3, 12);
            this.tableLayoutPanel1.Controls.Add(this.oneUpCount, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.coinCount, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(ifBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.currentStage, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.249085F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.005513F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.666423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.246645F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.733922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.733922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.360538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.394885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.413206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.367907F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.263381F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1157, 779);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanel1_CellPaint);
            // 
            // listBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBox1, 4);
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(761, 221);
            this.listBox1.Margin = new System.Windows.Forms.Padding(8, 13, 20, 3);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1, 6);
            this.listBox1.Size = new System.Drawing.Size(244, 426);
            this.listBox1.TabIndex = 16;
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.forBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(756, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 61);
            this.panel3.TabIndex = 25;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDown1.Location = new System.Drawing.Point(118, 14);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(23, 3, 3, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 34);
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
            this.forBtn.Name = "forBtn";
            this.forBtn.Size = new System.Drawing.Size(136, 61);
            this.forBtn.TabIndex = 1;
            this.forBtn.Text = "　　\r\n";
            this.forBtn.UseVisualStyleBackColor = true;
            // 
            // whileBtn
            // 
            this.whileBtn.BackgroundImage = global::unilab2019.Properties.Resources.ずっと1;
            this.whileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.whileBtn, 2);
            this.whileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.whileBtn.Location = new System.Drawing.Point(756, 154);
            this.whileBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.whileBtn.Name = "whileBtn";
            this.whileBtn.Size = new System.Drawing.Size(136, 54);
            this.whileBtn.TabIndex = 0;
            this.whileBtn.UseVisualStyleBackColor = true;
            // 
            // turnRightBtn
            // 
            this.turnRightBtn.BackColor = System.Drawing.Color.Lime;
            this.turnRightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnRightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnRightBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.turnRightBtn.Location = new System.Drawing.Point(1028, 87);
            this.turnRightBtn.Name = "turnRightBtn";
            this.turnRightBtn.Size = new System.Drawing.Size(76, 58);
            this.turnRightBtn.TabIndex = 6;
            this.turnRightBtn.Text = "右を向く";
            this.turnRightBtn.UseVisualStyleBackColor = false;
            // 
            // turnLeftBtn
            // 
            this.turnLeftBtn.BackColor = System.Drawing.Color.Lime;
            this.turnLeftBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.turnLeftBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.turnLeftBtn.Location = new System.Drawing.Point(945, 87);
            this.turnLeftBtn.Name = "turnLeftBtn";
            this.turnLeftBtn.Size = new System.Drawing.Size(77, 58);
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
            this.goForwardBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.goForwardBtn.Location = new System.Drawing.Point(975, 20);
            this.goForwardBtn.Margin = new System.Windows.Forms.Padding(33, 3, 33, 3);
            this.goForwardBtn.Name = "goForwardBtn";
            this.tableLayoutPanel1.SetRowSpan(this.goForwardBtn, 2);
            this.goForwardBtn.Size = new System.Drawing.Size(99, 61);
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
            this.stopBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.stopBtn.Location = new System.Drawing.Point(975, 151);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(33, 3, 33, 3);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 54);
            this.stopBtn.TabIndex = 22;
            this.stopBtn.Text = "止まる";
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // deleteOneBtn
            // 
            this.deleteOneBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteOneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteOneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteOneBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteOneBtn.ForeColor = System.Drawing.Color.Yellow;
            this.deleteOneBtn.Location = new System.Drawing.Point(1028, 425);
            this.deleteOneBtn.Name = "deleteOneBtn";
            this.deleteOneBtn.Size = new System.Drawing.Size(76, 51);
            this.deleteOneBtn.TabIndex = 7;
            this.deleteOneBtn.Text = "1つ削除";
            this.deleteOneBtn.UseVisualStyleBackColor = false;
            // 
            // deleteAllBtn
            // 
            this.deleteAllBtn.BackColor = System.Drawing.Color.Black;
            this.deleteAllBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAllBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.deleteAllBtn.ForeColor = System.Drawing.Color.White;
            this.deleteAllBtn.Location = new System.Drawing.Point(1028, 482);
            this.deleteAllBtn.Name = "deleteAllBtn";
            this.deleteAllBtn.Size = new System.Drawing.Size(76, 51);
            this.deleteAllBtn.TabIndex = 8;
            this.deleteAllBtn.Text = "全て削除";
            this.deleteAllBtn.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Brown;
            this.startBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(1028, 549);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.startBtn.Name = "startBtn";
            this.tableLayoutPanel1.SetRowSpan(this.startBtn, 2);
            this.startBtn.Size = new System.Drawing.Size(76, 88);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "実行！";
            this.startBtn.UseVisualStyleBackColor = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.resetBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.resetBtn.Location = new System.Drawing.Point(1028, 653);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(76, 51);
            this.resetBtn.TabIndex = 26;
            this.resetBtn.Text = "プレーヤー\r\nをリセット";
            this.resetBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(44, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 8);
            this.pictureBox1.Size = new System.Drawing.Size(706, 553);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // numOfLines
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.numOfLines, 4);
            this.numOfLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numOfLines.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numOfLines.Location = new System.Drawing.Point(761, 666);
            this.numOfLines.Margin = new System.Windows.Forms.Padding(8, 16, 20, 13);
            this.numOfLines.Name = "numOfLines";
            this.numOfLines.ReadOnly = true;
            this.numOfLines.Size = new System.Drawing.Size(244, 31);
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
            this.countTime.Location = new System.Drawing.Point(761, 710);
            this.countTime.Margin = new System.Windows.Forms.Padding(8, 3, 20, 3);
            this.countTime.Name = "countTime";
            this.countTime.ReadOnly = true;
            this.countTime.Size = new System.Drawing.Size(244, 31);
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
            this.oneUpCount.Location = new System.Drawing.Point(440, 710);
            this.oneUpCount.Margin = new System.Windows.Forms.Padding(43, 3, 20, 3);
            this.oneUpCount.Name = "oneUpCount";
            this.oneUpCount.ReadOnly = true;
            this.oneUpCount.Size = new System.Drawing.Size(293, 31);
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
            this.coinCount.Location = new System.Drawing.Point(44, 710);
            this.coinCount.Margin = new System.Windows.Forms.Padding(3, 3, 43, 3);
            this.coinCount.Name = "coinCount";
            this.coinCount.ReadOnly = true;
            this.coinCount.Size = new System.Drawing.Size(310, 31);
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
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(43, 86);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(299, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "壁",
            "敵",
            "道"});
            this.comboBox2.Location = new System.Drawing.Point(815, 51);
            this.comboBox2.MaxLength = 10;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 31);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "前",
            "後ろ",
            "右",
            "左"});
            this.comboBox1.Location = new System.Drawing.Point(815, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(77, 31);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(898, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "が";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(898, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 36);
            this.label2.TabIndex = 31;
            this.label2.Text = "なら";
            // 
            // currentStage
            // 
            this.currentStage.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.currentStage.Location = new System.Drawing.Point(44, 40);
            this.currentStage.Margin = new System.Windows.Forms.Padding(3, 23, 43, 3);
            this.currentStage.Name = "currentStage";
            this.currentStage.ReadOnly = true;
            this.currentStage.Size = new System.Drawing.Size(310, 31);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 779);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox coinCount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox countTime;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}