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
            }
        }

        void createNewBox()
        {


        }

    }
    
}
