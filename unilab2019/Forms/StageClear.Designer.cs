namespace unilab2019.Forms
{
    partial class StageClear
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.戻る = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.戻る, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(235, 357);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // 戻る
            // 
            this.戻る.BackColor = System.Drawing.Color.Red;
            this.戻る.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.戻る.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.戻る.Location = new System.Drawing.Point(3, 3);
            this.戻る.Name = "戻る";
            this.戻る.Size = new System.Drawing.Size(273, 75);
            this.戻る.TabIndex = 0;
            this.戻る.Text = "ステージ選択画面に戻る";
            this.戻る.UseVisualStyleBackColor = false;
            this.戻る.Click += new System.EventHandler(this.戻る_Click);
            // 
            // StageClear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::unilab2019.Properties.Resources.クリア画面;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StageClear";
            this.Text = "StageClear";
            this.Load += new System.EventHandler(this.StageClear_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button 戻る;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}