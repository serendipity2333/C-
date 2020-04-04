namespace homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawButton = new System.Windows.Forms.Button();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.textBoxTh2 = new System.Windows.Forms.TextBox();
            this.per1Label = new System.Windows.Forms.Label();
            this.per2Label = new System.Windows.Forms.Label();
            this.th1Label = new System.Windows.Forms.Label();
            this.th2Label = new System.Windows.Forms.Label();
            this.trackBarPer1 = new System.Windows.Forms.TrackBar();
            this.trackBarPer2 = new System.Windows.Forms.TrackBar();
            this.listBoxN = new System.Windows.Forms.ListBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.textBoxLeng = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTh1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer2)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(927, 41);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 29);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "蓝色",
            "绿色",
            "红色"});
            this.colorComboBox.Location = new System.Drawing.Point(770, 45);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 23);
            this.colorComboBox.TabIndex = 1;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(792, 18);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(67, 15);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "选择颜色";
            // 
            // textBoxTh2
            // 
            this.textBoxTh2.Location = new System.Drawing.Point(389, 79);
            this.textBoxTh2.Name = "textBoxTh2";
            this.textBoxTh2.Size = new System.Drawing.Size(100, 25);
            this.textBoxTh2.TabIndex = 4;
            // 
            // per1Label
            // 
            this.per1Label.AutoSize = true;
            this.per1Label.Location = new System.Drawing.Point(39, 36);
            this.per1Label.Name = "per1Label";
            this.per1Label.Size = new System.Drawing.Size(97, 15);
            this.per1Label.TabIndex = 5;
            this.per1Label.Text = "右分支长度比";
            // 
            // per2Label
            // 
            this.per2Label.AutoSize = true;
            this.per2Label.Location = new System.Drawing.Point(39, 79);
            this.per2Label.Name = "per2Label";
            this.per2Label.Size = new System.Drawing.Size(97, 15);
            this.per2Label.TabIndex = 6;
            this.per2Label.Text = "左分支长度比";
            // 
            // th1Label
            // 
            this.th1Label.AutoSize = true;
            this.th1Label.Location = new System.Drawing.Point(288, 32);
            this.th1Label.Name = "th1Label";
            this.th1Label.Size = new System.Drawing.Size(82, 15);
            this.th1Label.TabIndex = 7;
            this.th1Label.Text = "右分支角度";
            // 
            // th2Label
            // 
            this.th2Label.AutoSize = true;
            this.th2Label.Location = new System.Drawing.Point(288, 79);
            this.th2Label.Name = "th2Label";
            this.th2Label.Size = new System.Drawing.Size(82, 15);
            this.th2Label.TabIndex = 8;
            this.th2Label.Text = "左分支角度";
            // 
            // trackBarPer1
            // 
            this.trackBarPer1.Location = new System.Drawing.Point(142, 18);
            this.trackBarPer1.Name = "trackBarPer1";
            this.trackBarPer1.Size = new System.Drawing.Size(104, 56);
            this.trackBarPer1.TabIndex = 9;
            // 
            // trackBarPer2
            // 
            this.trackBarPer2.Location = new System.Drawing.Point(142, 76);
            this.trackBarPer2.Name = "trackBarPer2";
            this.trackBarPer2.Size = new System.Drawing.Size(104, 56);
            this.trackBarPer2.TabIndex = 10;
            // 
            // listBoxN
            // 
            this.listBoxN.FormattingEnabled = true;
            this.listBoxN.ItemHeight = 15;
            this.listBoxN.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.listBoxN.Location = new System.Drawing.Point(622, 32);
            this.listBoxN.Name = "listBoxN";
            this.listBoxN.Size = new System.Drawing.Size(59, 19);
            this.listBoxN.TabIndex = 11;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(528, 36);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(67, 15);
            this.labelN.TabIndex = 12;
            this.labelN.Text = "递归深度";
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(528, 79);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(67, 15);
            this.labelLength.TabIndex = 13;
            this.labelLength.Text = "主干长度";
            // 
            // textBoxLeng
            // 
            this.textBoxLeng.Location = new System.Drawing.Point(622, 76);
            this.textBoxLeng.Name = "textBoxLeng";
            this.textBoxLeng.Size = new System.Drawing.Size(100, 25);
            this.textBoxLeng.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(124, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 412);
            this.panel1.TabIndex = 15;
            // 
            // textBoxTh1
            // 
            this.textBoxTh1.Location = new System.Drawing.Point(389, 26);
            this.textBoxTh1.Name = "textBoxTh1";
            this.textBoxTh1.Size = new System.Drawing.Size(100, 25);
            this.textBoxTh1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.DrawButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 553);
            this.Controls.Add(this.trackBarPer1);
            this.Controls.Add(this.textBoxTh2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxLeng);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.listBoxN);
            this.Controls.Add(this.trackBarPer2);
            this.Controls.Add(this.th2Label);
            this.Controls.Add(this.th1Label);
            this.Controls.Add(this.per2Label);
            this.Controls.Add(this.per1Label);
            this.Controls.Add(this.textBoxTh1);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox textBoxTh2;
        private System.Windows.Forms.Label per1Label;
        private System.Windows.Forms.Label per2Label;
        private System.Windows.Forms.Label th1Label;
        private System.Windows.Forms.Label th2Label;
        private System.Windows.Forms.TrackBar trackBarPer1;
        private System.Windows.Forms.TrackBar trackBarPer2;
        private System.Windows.Forms.ListBox listBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.TextBox textBoxLeng;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTh1;
    }
}

