namespace clipboard
{
    partial class mainBoard
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
            this.rtBoard1 = new System.Windows.Forms.RichTextBox();
            this.rtBoard2 = new System.Windows.Forms.RichTextBox();
            this.debugText1 = new System.Windows.Forms.TextBox();
            this.debugText2 = new System.Windows.Forms.TextBox();
            this.rtBoard3 = new System.Windows.Forms.RichTextBox();
            this.rtBoard4 = new System.Windows.Forms.RichTextBox();
            this.onTopChkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rtBoard1
            // 
            this.rtBoard1.Location = new System.Drawing.Point(13, 13);
            this.rtBoard1.Name = "rtBoard1";
            this.rtBoard1.Size = new System.Drawing.Size(176, 125);
            this.rtBoard1.TabIndex = 0;
            this.rtBoard1.Text = "";
            // 
            // rtBoard2
            // 
            this.rtBoard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBoard2.Location = new System.Drawing.Point(194, 13);
            this.rtBoard2.Name = "rtBoard2";
            this.rtBoard2.Size = new System.Drawing.Size(176, 125);
            this.rtBoard2.TabIndex = 1;
            this.rtBoard2.Text = "";
            // 
            // debugText1
            // 
            this.debugText1.Location = new System.Drawing.Point(375, 13);
            this.debugText1.Name = "debugText1";
            this.debugText1.Size = new System.Drawing.Size(32, 20);
            this.debugText1.TabIndex = 2;
            // 
            // debugText2
            // 
            this.debugText2.Location = new System.Drawing.Point(375, 40);
            this.debugText2.Name = "debugText2";
            this.debugText2.Size = new System.Drawing.Size(32, 20);
            this.debugText2.TabIndex = 3;
            // 
            // rtBoard3
            // 
            this.rtBoard3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtBoard3.Location = new System.Drawing.Point(13, 142);
            this.rtBoard3.Name = "rtBoard3";
            this.rtBoard3.Size = new System.Drawing.Size(176, 125);
            this.rtBoard3.TabIndex = 4;
            this.rtBoard3.Text = "";
            // 
            // rtBoard4
            // 
            this.rtBoard4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtBoard4.Location = new System.Drawing.Point(194, 142);
            this.rtBoard4.Name = "rtBoard4";
            this.rtBoard4.Size = new System.Drawing.Size(176, 125);
            this.rtBoard4.TabIndex = 5;
            this.rtBoard4.Text = "";
            // 
            // onTopChkbox
            // 
            this.onTopChkbox.AutoSize = true;
            this.onTopChkbox.Location = new System.Drawing.Point(375, 67);
            this.onTopChkbox.Name = "onTopChkbox";
            this.onTopChkbox.Size = new System.Drawing.Size(48, 17);
            this.onTopChkbox.TabIndex = 6;
            this.onTopChkbox.Text = "TOP";
            this.onTopChkbox.UseVisualStyleBackColor = true;
            this.onTopChkbox.CheckedChanged += new System.EventHandler(this.onTopChkbox_CheckedChanged);
            // 
            // mainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 278);
            this.Controls.Add(this.onTopChkbox);
            this.Controls.Add(this.rtBoard4);
            this.Controls.Add(this.rtBoard3);
            this.Controls.Add(this.debugText2);
            this.Controls.Add(this.debugText1);
            this.Controls.Add(this.rtBoard2);
            this.Controls.Add(this.rtBoard1);
            this.Name = "mainBoard";
            this.Text = "Clipboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoard1;
        private System.Windows.Forms.RichTextBox rtBoard2;
        private System.Windows.Forms.TextBox debugText1;
        private System.Windows.Forms.TextBox debugText2;
        private System.Windows.Forms.RichTextBox rtBoard3;
        private System.Windows.Forms.RichTextBox rtBoard4;
        private System.Windows.Forms.CheckBox onTopChkbox;
    }
}

