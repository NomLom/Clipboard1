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
    public partial class HistoryForm1 : Form


    {
        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["MainBoard"];
        public HistoryForm1()
        {
            InitializeComponent();
            listBoxHistory.DataSource = ((MainBoard)f)._textBoxHistory;

        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listBoxHistory = MainBoard.

            
        }
    }
}
