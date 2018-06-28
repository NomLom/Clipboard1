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
        public mainBoard()
        {
            InitializeComponent();
            // HandleCustomEvent();

            ClipboardMonitor.ClipboardUpdate += (object sender, EventArgs e) =>
            {
                var clipboardText = Clipboard.GetText();
                MessageBox.Show(clipboardText);
            };


        }

    }
    
}
