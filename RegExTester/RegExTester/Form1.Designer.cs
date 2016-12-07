namespace RegExTester
{
    partial class Form1
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
            this.cbxPreloaded = new System.Windows.Forms.ComboBox();
            this.txtRegEx = new System.Windows.Forms.TextBox();
            this.txtTestText = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preloaded Expressions:";
            // 
            // cbxPreloaded
            // 
            this.cbxPreloaded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPreloaded.FormattingEnabled = true;
            this.cbxPreloaded.Items.AddRange(new object[] {
            "",
            "Email",
            "Phone Number",
            "Numbers",
            "Zip Code",
            "Currency",
            "Social"});
            this.cbxPreloaded.Location = new System.Drawing.Point(133, 10);
            this.cbxPreloaded.Name = "cbxPreloaded";
            this.cbxPreloaded.Size = new System.Drawing.Size(121, 21);
            this.cbxPreloaded.TabIndex = 1;
            this.cbxPreloaded.SelectedIndexChanged += new System.EventHandler(this.cbxPreloaded_SelectedIndexChanged);
            // 
            // txtRegEx
            // 
            this.txtRegEx.Location = new System.Drawing.Point(12, 37);
            this.txtRegEx.Name = "txtRegEx";
            this.txtRegEx.Size = new System.Drawing.Size(242, 20);
            this.txtRegEx.TabIndex = 2;
            // 
            // txtTestText
            // 
            this.txtTestText.Location = new System.Drawing.Point(12, 64);
            this.txtTestText.Multiline = true;
            this.txtTestText.Name = "txtTestText";
            this.txtTestText.Size = new System.Drawing.Size(242, 139);
            this.txtTestText.TabIndex = 3;
            this.txtTestText.TextChanged += new System.EventHandler(this.txtTestText_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 265);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtTestText);
            this.Controls.Add(this.txtRegEx);
            this.Controls.Add(this.cbxPreloaded);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RegEx Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPreloaded;
        private System.Windows.Forms.TextBox txtRegEx;
        private System.Windows.Forms.TextBox txtTestText;
        private System.Windows.Forms.Label lblResult;
    }
}

