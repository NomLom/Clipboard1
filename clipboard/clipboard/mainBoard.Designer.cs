﻿namespace clipboard
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
            this.SuspendLayout();
            // 
            // rtBoard1
            // 
            this.rtBoard1.Location = new System.Drawing.Point(13, 13);
            this.rtBoard1.Name = "rtBoard1";
            this.rtBoard1.Size = new System.Drawing.Size(160, 123);
            this.rtBoard1.TabIndex = 0;
            this.rtBoard1.Text = "";
            // 
            // rtBoard2
            // 
            this.rtBoard2.Location = new System.Drawing.Point(195, 13);
            this.rtBoard2.Name = "rtBoard2";
            this.rtBoard2.Size = new System.Drawing.Size(173, 123);
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
            // mainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 351);
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
    }
}

