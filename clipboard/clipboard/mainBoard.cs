using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clipboard
{

    

    public partial class mainBoard : Form
    {
        List<RichTextBox> textBoxes = new List<RichTextBox>() ;
        int textboxnumber = 0;


        public mainBoard()
          

        {
            InitializeComponent();
            // HandleCustomEvent();
            textBoxes.Add(rtBoard1);
            textBoxes.Add(rtBoard2);
            textBoxes.Add(rtBoard3);
            textBoxes.Add(rtBoard4);
            this.ActiveControl = debugText1;

            foreach (RichTextBox tb in this.Controls.OfType<RichTextBox>())
            {
                tb.Enter += TextBox_GotFocus;
            }



            for (int i = 0; i < textBoxes.Count; i++)
            {
            //    rtBoard1[i] = textBoxes[i].Text;
            }


            ClipboardMonitor.ClipboardUpdate += (object sender, EventArgs e) =>
            {
               // int p = textBoxes.Count;
               // if (p == 0) { }


                var clipboardText = Clipboard.GetText();
                textBoxes[textboxnumber].Text = clipboardText;

                debugText1.Text = textboxnumber.ToString();
                debugText2.Text = textBoxes.Count.ToString();
                // MessageBox.Show(clipboardText);
                incrementtextboxnumber();
            };


  


        }

        public void incrementtextboxnumber()
        {
            textboxnumber++;
            if ( textboxnumber >= textBoxes.Count)
            {
                textboxnumber = 0;
                this.ActiveControl = debugText1;
            }
        }

        private RichTextBox focusedControl;

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            focusedControl = (RichTextBox)sender;
            if (focusedControl.Text != "")
            {
              //  MessageBox.Show(focusedControl.Text);
                ClipboardMonitor.Stop();
                Clipboard.SetText(focusedControl.Text);
                this.ActiveControl = debugText1;
                ClipboardMonitor.Start();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (focusedControl != null)
            {

                focusedControl.Text += "1";
                //MessageBox.Show(focusedControl.Text);
            }

        }




        void createNewBox()
        {


        }

        private void onTopChkbox_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = onTopChkbox.Checked;
        }
    }
    
}
