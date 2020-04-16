namespace homework8
{
    partial class FormChange
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
            this.buttonChange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.comboBoxOld = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNew = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(172, 214);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(101, 46);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "确认修改";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "数量";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(299, 162);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(121, 25);
            this.textBoxNumber.TabIndex = 7;
            // 
            // comboBoxOld
            // 
            this.comboBoxOld.FormattingEnabled = true;
            this.comboBoxOld.Items.AddRange(new object[] {
            "hat",
            "chair",
            "table",
            "cup"});
            this.comboBoxOld.Location = new System.Drawing.Point(119, 93);
            this.comboBoxOld.Name = "comboBoxOld";
            this.comboBoxOld.Size = new System.Drawing.Size(100, 23);
            this.comboBoxOld.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "修改为";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "修改为";
            // 
            // comboBoxNew
            // 
            this.comboBoxNew.FormattingEnabled = true;
            this.comboBoxNew.Items.AddRange(new object[] {
            "hat",
            "chair",
            "table",
            "cup"});
            this.comboBoxNew.Location = new System.Drawing.Point(299, 93);
            this.comboBoxNew.Name = "comboBoxNew";
            this.comboBoxNew.Size = new System.Drawing.Size(121, 23);
            this.comboBoxNew.TabIndex = 12;
            // 
            // FormChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 293);
            this.Controls.Add(this.comboBoxNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOld);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChange);
            this.Name = "FormChange";
            this.Text = "FormChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.ComboBox comboBoxOld;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNew;
    }
}