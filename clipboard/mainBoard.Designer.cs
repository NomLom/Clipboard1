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
            // mainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 351);
            this.Controls.Add(this.rtBoard1);
            this.Name = "mainBoard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoard1;
    }
}

