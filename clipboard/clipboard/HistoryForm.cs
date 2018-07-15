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
        private MainBoard mainBoardRef;
        
        //System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["MainBoard"];
        public HistoryForm1(MainBoard mainBoard)
        {
            mainBoardRef = mainBoard; 
            InitializeComponent();
           
            listBoxHistory.DataSource = mainBoard._textBoxHistory;
            listBoxHistory.SelectedIndex = 1;
            //listBoxHistory.DataBindings.Add(new Binding("DataSource", mainBoardRef.bindingSource1,"fffuck"));

        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // listBoxHistory = MainBoard.

            
        }

        public void updateHistory()
        {
            //listBoxHistory.DataSource = mainBoardRef._textBoxHistory;
            //Prop
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
