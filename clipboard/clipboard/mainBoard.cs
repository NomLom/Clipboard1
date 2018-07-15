using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace clipboard
{

    public partial class MainBoard : Form
    {
        private readonly List<RichTextBox> _textBoxes = new List<RichTextBox>() ;
        public ObservableCollection<String> _textBoxHistory = new ObservableCollection<String>();
        private HistoryForm1 frm2;
        private int _textboxnumber;
        private int _lasttextboxnumber;
        private int _historyBoxNumber = 0;
        public Color ColorPasteFlash = Color.LightGreen;
        public Color ColorCurrentHighlight = Color.LightYellow;
        public Color ColourTextBox = Color.White;
        //public Color ColourForeColour = SystemColors.ControlText;
        //public Color ColourBackColour = SystemColors.Control;
        public BindingSource bindingSource1;
        


        public MainBoard()

        {
            bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _textBoxHistory;

            InitializeComponent();
            //this.BackColor = SystemColors.Control;
            // HandleCustomEvent();
            _textBoxes.Add(rtBoard1);
            _textBoxes.Add(rtBoard2);
            _textBoxes.Add(rtBoard3);
            _textBoxes.Add(rtBoard4);
            ActiveControl = debugText1;

            for (int i = 0; i < 20; i++)
            {
                _textBoxHistory.Add(String.Empty);
            }

            foreach (var tb in tableLayoutPanel1.Controls.OfType<RichTextBox>())
            {
                tb.Enter += TextBox_GotFocus;
            }



            //for (int i = 0; i < _textBoxes.Count; i++)
            //{
            //    rtBoard1[i] = textBoxes[i].Text;
            //}


            ClipboardMonitor.ClipboardUpdate += (sender, e) =>
            {
                //this bit populates the clipboard for use
                var clipboardText = Clipboard.GetText();

                //this bit sets up a test comparison textbox, as I was finding that some Pc's copy twice to cliipboard when 
                //ctrl+c was pressed, so I needed to dedupe it
                RichTextBox chk = new RichTextBox {Text = clipboardText};
                //and for some reason \r\n changes to \m when rendered in a textbox only on screen
                if ((_textBoxes[_lasttextboxnumber].Text.Replace("\r\n", "\n") == chk.Text.Replace("\r\n", "\n")) ||
                    (string.IsNullOrEmpty(clipboardText))) return;
                if (_textBoxes[_textboxnumber].Text != "")
                {
                    _textBoxHistory[_historyBoxNumber] = (_textBoxes[_textboxnumber].Text);
                    IncrementHistoryBoxNumber();
                    if (frm2 != null)
                    {
                        frm2.updateHistory();
                    };
                }
                _textBoxes[_textboxnumber].Text = clipboardText;
                debugText1.Text = _historyBoxNumber.ToString(); // _textboxnumber.ToString();
                debugText2.Text = _lasttextboxnumber.ToString();
                _textBoxes[_lasttextboxnumber].BackColor = ColourTextBox;
                _lasttextboxnumber = _textboxnumber;
                _textBoxes[_textboxnumber].BackColor = ColorCurrentHighlight;
                Incrementtextboxnumber();
                // incrementtextboxnumber();
                //HistoryForm1.hi = _textBoxHistory;
            };
        }

        public void IncrementHistoryBoxNumber()
        {
           
            _historyBoxNumber++;
            if (_historyBoxNumber < 20) return;
            _historyBoxNumber = 0;
        }

        public void Incrementtextboxnumber()
        {
            _textboxnumber++;
            if (_textboxnumber < _textBoxes.Count) return;
            _textboxnumber = 0;
            ActiveControl = debugText1;
        }

        private RichTextBox _focusedControl;

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            _focusedControl = (RichTextBox)sender;

            if (_focusedControl.Text == "") return;
            //  MessageBox.Show(focusedControl.Text);
            //we need to stop the monitoring of clipboard changes if we are changing the clipboard intentionally. 
            ClipboardMonitor.Stop();
            Clipboard.SetText(_focusedControl.Text);
            Blink();  //flash that textbox!
            ClipboardMonitor.Start();
        }

        private async void Blink() //This method is async and allows text box colour changes in real time.
        {
            var chk = new RichTextBox {BackColor = _focusedControl.BackColor};
            for (var i = 0; i < 2; i++)
            {
                await Task.Delay(250);
                _focusedControl.BackColor = _focusedControl.BackColor == ColorPasteFlash ? chk.BackColor : ColorPasteFlash;
            }
        }

        private void OnTopChkbox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = onTopChkbox.Checked;
        }

        private void CheckBoxBorderless_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckBox;
            FormBorderStyle =
                (checkBox != null && checkBox.Checked ? FormBorderStyle.None : FormBorderStyle.Sizable);
            Opacity =
                (checkBox != null && checkBox.Checked ? 0.67 : 1);

        }

        private void DrkCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ForeColor = (((CheckBox) sender).Checked ? SystemColors.ControlLight : SystemColors.ControlText);
            BackColor = (((CheckBox) sender).Checked ? Color.Black : SystemColors.Control);
            ColorCurrentHighlight = (((CheckBox) sender).Checked ? Color.DarkSlateGray : Color.LightYellow);
            ColourTextBox = (((CheckBox) sender).Checked ? Color.Black : Color.White);
            _textBoxes[_lasttextboxnumber].BackColor = ColorCurrentHighlight;

            foreach (var elem in _textBoxes)  //let's colour in our new shades man.  fk the highlighted colour atm.
            {
                if (elem == null) continue;
                elem.BackColor = (sender != null && ((CheckBox) sender).Checked ? Color.Black : Color.White);
                elem.ForeColor = (sender != null && ((CheckBox) sender).Checked ? Color.LightGreen : SystemColors.ControlText);
            }
        }


        /*private void button1_Click(object sender, EventArgs e)
        {
            


            HistoryForm1 frm2 = new HistoryForm1();
            frm2.Show();
        }  */


        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             frm2 = new HistoryForm1(this);
            frm2.Show();
            
        }
    }
    
}
