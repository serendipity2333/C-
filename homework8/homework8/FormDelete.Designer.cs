namespace homework8
{
    partial class FormDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入删除的订单编号";
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(238, 71);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(96, 25);
            this.textBoxDelete.TabIndex = 1;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(165, 169);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 35);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "确认删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "删除结果";
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.label1);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
    }
}