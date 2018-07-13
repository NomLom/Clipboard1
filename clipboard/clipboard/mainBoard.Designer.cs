namespace clipboard
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.rtBoard1 = new System.Windows.Forms.RichTextBox();
            this.rtBoard2 = new System.Windows.Forms.RichTextBox();
            this.debugText1 = new System.Windows.Forms.TextBox();
            this.debugText2 = new System.Windows.Forms.TextBox();
            this.rtBoard3 = new System.Windows.Forms.RichTextBox();
            this.rtBoard4 = new System.Windows.Forms.RichTextBox();
            this.onTopChkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxBorderless = new System.Windows.Forms.CheckBox();
            this.drkCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtBoard1
            // 
            this.rtBoard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard1.Location = new System.Drawing.Point(3, 3);
            this.rtBoard1.Name = "rtBoard1";
            this.rtBoard1.Size = new System.Drawing.Size(99, 75);
            this.rtBoard1.TabIndex = 0;
            this.rtBoard1.Text = "";
            // 
            // rtBoard2
            // 
            this.rtBoard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard2.Location = new System.Drawing.Point(108, 3);
            this.rtBoard2.Name = "rtBoard2";
            this.rtBoard2.Size = new System.Drawing.Size(99, 75);
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
            this.debugText2.Location = new System.Drawing.Point(3, 40);
            this.debugText2.Name = "debugText2";
            this.debugText2.Size = new System.Drawing.Size(26, 20);
            this.debugText2.TabIndex = 3;
            // 
            // rtBoard3
            // 
            this.rtBoard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard3.Location = new System.Drawing.Point(3, 84);
            this.rtBoard3.Name = "rtBoard3";
            this.rtBoard3.Size = new System.Drawing.Size(99, 75);
            this.rtBoard3.TabIndex = 4;
            this.rtBoard3.Text = "";
            // 
            // rtBoard4
            // 
            this.rtBoard4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtBoard4.Location = new System.Drawing.Point(108, 84);
            this.rtBoard4.Name = "rtBoard4";
            this.rtBoard4.Size = new System.Drawing.Size(99, 75);
            this.rtBoard4.TabIndex = 5;
            this.rtBoard4.Text = "";
            // 
            // onTopChkbox
            // 
            this.onTopChkbox.AutoSize = true;
            this.onTopChkbox.Location = new System.Drawing.Point(2, 2);
            this.onTopChkbox.Margin = new System.Windows.Forms.Padding(2);
            this.onTopChkbox.Name = "onTopChkbox";
            this.onTopChkbox.Size = new System.Drawing.Size(48, 17);
            this.onTopChkbox.TabIndex = 6;
            this.onTopChkbox.Text = "TOP";
            this.onTopChkbox.UseVisualStyleBackColor = true;
            this.onTopChkbox.CheckedChanged += new System.EventHandler(this.OnTopChkbox_CheckedChanged);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 162);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxBorderless, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.onTopChkbox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.drkCheckbox, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(210, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(54, 81);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // checkBoxBorderless
            // 
            this.checkBoxBorderless.AutoSize = true;
            this.checkBoxBorderless.Location = new System.Drawing.Point(2, 29);
            this.checkBoxBorderless.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBorderless.Name = "checkBoxBorderless";
            this.checkBoxBorderless.Size = new System.Drawing.Size(48, 17);
            this.checkBoxBorderless.TabIndex = 9;
            this.checkBoxBorderless.Text = "ANC";
            this.checkBoxBorderless.UseVisualStyleBackColor = true;
            this.checkBoxBorderless.CheckedChanged += new System.EventHandler(this.CheckBoxBorderless_CheckedChanged);
            // 
            // drkCheckbox
            // 
            this.drkCheckbox.AutoSize = true;
            this.drkCheckbox.Location = new System.Drawing.Point(2, 56);
            this.drkCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.drkCheckbox.Name = "drkCheckbox";
            this.drkCheckbox.Size = new System.Drawing.Size(49, 17);
            this.drkCheckbox.TabIndex = 10;
            this.drkCheckbox.Text = "DRK";
            this.drkCheckbox.UseVisualStyleBackColor = true;
            this.drkCheckbox.CheckedChanged += new System.EventHandler(this.DrkCheckbox_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.debugText2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.debugText1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(213, 84);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(32, 75);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 277);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBoard";
            this.Text = "Clipboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.CheckBox drkCheckbox;
        private System.Windows.Forms.Button button1;
    }
}

