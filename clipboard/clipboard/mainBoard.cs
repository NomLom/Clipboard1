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
        int lasttextboxnumber = 0;
        public Color colorPasteFlash = Color.LightGreen;
        public Color colorCurrentHighlight = Color.LightYellow;
        public Color colourTextBox = Color.White;
        public Color colourForeColour = SystemColors.ControlText;
        public Color colourBackColour = SystemColors.Control;




        public mainBoard()
          

        {
            InitializeComponent();
            //this.BackColor = SystemColors.Control;
            // HandleCustomEvent();
            textBoxes.Add(rtBoard1);
            textBoxes.Add(rtBoard2);
            textBoxes.Add(rtBoard3);
            textBoxes.Add(rtBoard4);
            this.ActiveControl = debugText1;

            foreach (RichTextBox tb in tableLayoutPanel1.Controls.OfType<RichTextBox>())
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

                //this bit populates the clipboard for use
                var clipboardText = Clipboard.GetText();

                //this bit sets up a test comparison textbox, as I was finding that some Pc's copy twice to cliipboard when 
                //ctrl+c was pressed, so I needed to dedupe it
                RichTextBox chk = new RichTextBox();
                chk.Text = clipboardText;
                //and for some reason \r\n changes to \m when rendered in a textbox only on screen
                if (textBoxes[lasttextboxnumber].Text.Replace("\r\n", "\n") != chk.Text.Replace("\r\n", "\n"))
                {
                    textBoxes[textboxnumber].Text = clipboardText;

                    debugText1.Text = textboxnumber.ToString();
                    debugText2.Text = lasttextboxnumber.ToString();
                    //MessageBox.Show(clipboardText);
                    //MessageBox.Show(textBoxes[textboxnumber].Text);
                    
                    
                    textBoxes[lasttextboxnumber].BackColor = colourTextBox;
                    lasttextboxnumber = textboxnumber;
                    textBoxes[textboxnumber].BackColor = colorCurrentHighlight;
                    incrementtextboxnumber();
                }
               // incrementtextboxnumber();
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
            RichTextBox chk = new RichTextBox();
            if (focusedControl.Text != "")
            {
              //  MessageBox.Show(focusedControl.Text);
              //we need to stop the monitoring of clipboard changes if we are changing the clipboard intentionally. 
                ClipboardMonitor.Stop();
                Clipboard.SetText(focusedControl.Text);     
                chk.BackColor = focusedControl.BackColor;
                focusedControl.BackColor = colorPasteFlash;
                focusedControl.Refresh();
                System.Threading.Thread.Sleep(400);
                focusedControl.BackColor = chk.BackColor;
                focusedControl.Refresh();
                this.ActiveControl = debugText1;
                ClipboardMonitor.Start();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (focusedControl != null)
            {

               //focusedControl.Text += "1";
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

        private void checkBoxBorderless_CheckedChanged(object sender, EventArgs e)
        {
            this.FormBorderStyle =
                ((sender as CheckBox).Checked ? FormBorderStyle.None : FormBorderStyle.Sizable);
            //this.TransparencyKey = Color.Grey;
            this.Opacity =
                ((sender as CheckBox).Checked ? 0.6 : 1);
            //this.Opacity = 0.7;

        }

        private void drkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            this.ForeColor = ((sender as CheckBox).Checked ? SystemColors.ControlLight : SystemColors.ControlText);
            this.BackColor = ((sender as CheckBox).Checked ? Color.Black : SystemColors.Control);
            colorCurrentHighlight = ((sender as CheckBox).Checked ? Color.DarkSlateGray : Color.LightYellow);
            colourTextBox = ((sender as CheckBox).Checked ? Color.Black : Color.White);
            textBoxes[lasttextboxnumber].BackColor = colorCurrentHighlight;


            foreach (var elem in textBoxes)
            {
                if (elem is RichTextBox)
                {
                    (elem as RichTextBox).BackColor = ((sender as CheckBox).Checked ? Color.Black : Color.White);
                    (elem as RichTextBox).ForeColor = ((sender as CheckBox).Checked ? Color.LightGreen : SystemColors.ControlText);
                    
    }
            }
        }
    }
    
}
