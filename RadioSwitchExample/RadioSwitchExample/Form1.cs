using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioSwitchExample
{
    public partial class frmRadioSwitch : Form
    {
        public frmRadioSwitch()
        {
            InitializeComponent();
            lstBands.Items.Add("The Eagels");
        }

        private void radCoffee_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        } // End radCoffee

        private void radTea_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        } // End radTea

        private void btnRating_Click(object sender, EventArgs e)
        {
            string band;
            if (lstBands.SelectedIndex != -1) // See if item is selected
            {
                band = lstBands.SelectedItem.ToString();

                switch (band)
                {
                    case "Rolling Stone":
                        MessageBox.Show("Rating is 8");
                        break;
                    case "John Merk":
                        MessageBox.Show("Rating is 9");
                        break;
                    case "The Beetles":
                        MessageBox.Show("Rating is 10");
                        break;
                    case "The Eagels":
                        MessageBox.Show("Rating is 10");
                        break;

                } // End switch

            } // End if

            else
            {
                MessageBox.Show("Select a band.");
            } // End else

        } // End btnRating

    } // End class
} // End namespace
