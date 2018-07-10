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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainBoard));
            this.rtBoard1 = new System.Windows.Forms.RichTextBox();
            this.rtBoard2 = new System.Windows.Forms.RichTextBox();
            this.debugText1 = new System.Windows.Forms.TextBox();
            this.debugText2 = new System.Windows.Forms.TextBox();
            this.rtBoard3 = new System.Windows.Forms.RichTextBox();
            this.rtBoard4 = new System.Windows.Forms.RichTextBox();
            this.onTopChkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBorderless = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBoard1
            // 
            this.rtBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard1.Location = new System.Drawing.Point(3, 3);
            this.rtBoard1.Name = "rtBoard1";
            this.rtBoard1.Size = new System.Drawing.Size(189, 129);
            this.rtBoard1.TabIndex = 0;
            this.rtBoard1.Text = "";
            // 
            // rtBoard2
            // 
            this.rtBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard2.Location = new System.Drawing.Point(198, 3);
            this.rtBoard2.Name = "rtBoard2";
            this.rtBoard2.Size = new System.Drawing.Size(189, 129);
            this.rtBoard2.TabIndex = 1;
            this.rtBoard2.Text = "";
            // 
            // debugText1
            // 
            this.debugText1.Location = new System.Drawing.Point(3, 3);
            this.debugText1.Name = "debugText1";
            this.debugText1.Size = new System.Drawing.Size(26, 20);
            this.debugText1.TabIndex = 2;
            // 
            // debugText2
            // 
            this.debugText2.Location = new System.Drawing.Point(3, 68);
            this.debugText2.Name = "debugText2";
            this.debugText2.Size = new System.Drawing.Size(26, 20);
            this.debugText2.TabIndex = 3;
            // 
            // rtBoard3
            // 
            this.rtBoard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard3.Location = new System.Drawing.Point(3, 138);
            this.rtBoard3.Name = "rtBoard3";
            this.rtBoard3.Size = new System.Drawing.Size(189, 130);
            this.rtBoard3.TabIndex = 4;
            this.rtBoard3.Text = "";
            // 
            // rtBoard4
            // 
            this.rtBoard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard4.Location = new System.Drawing.Point(198, 138);
            this.rtBoard4.Name = "rtBoard4";
            this.rtBoard4.Size = new System.Drawing.Size(189, 130);
            this.rtBoard4.TabIndex = 5;
            this.rtBoard4.Text = "";
            // 
            // onTopChkbox
            // 
            this.onTopChkbox.AutoSize = true;
            this.onTopChkbox.Location = new System.Drawing.Point(3, 3);
            this.onTopChkbox.Name = "onTopChkbox";
            this.onTopChkbox.Size = new System.Drawing.Size(48, 17);
            this.onTopChkbox.TabIndex = 6;
            this.onTopChkbox.Text = "TOP";
            this.onTopChkbox.UseVisualStyleBackColor = true;
            this.onTopChkbox.CheckedChanged += new System.EventHandler(this.onTopChkbox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtBoard1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtBoard2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtBoard3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtBoard4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 271);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.debugText2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.debugText1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(393, 138);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(32, 130);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxBorderless, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.onTopChkbox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(390, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(54, 97);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // checkBoxBorderless
            // 
            this.checkBoxBorderless.AutoSize = true;
            this.checkBoxBorderless.Location = new System.Drawing.Point(3, 35);
            this.checkBoxBorderless.Name = "checkBoxBorderless";
            this.checkBoxBorderless.Size = new System.Drawing.Size(48, 17);
            this.checkBoxBorderless.TabIndex = 9;
            this.checkBoxBorderless.Text = "ANC";
            this.checkBoxBorderless.UseVisualStyleBackColor = true;
            this.checkBoxBorderless.CheckedChanged += new System.EventHandler(this.checkBoxBorderless_CheckedChanged);
            // 
            // mainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 271);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainBoard";
            this.Text = "Clipboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtBoard1;
        private System.Windows.Forms.RichTextBox rtBoard2;
        private System.Windows.Forms.TextBox debugText1;
        private System.Windows.Forms.TextBox debugText2;
        private System.Windows.Forms.RichTextBox rtBoard3;
        private System.Windows.Forms.RichTextBox rtBoard4;
        private System.Windows.Forms.CheckBox onTopChkbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox checkBoxBorderless;
    }
}

