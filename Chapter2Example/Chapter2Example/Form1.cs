using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2Example
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to CSC - 153");

            // Change Message on label
            lblWelcome.Text = "You clicked the button.";
        }

        private void btnWelcome_MouseHover(object sender, EventArgs e)
        {
            btnWelcome.Text = "Are you ready?";
        }

        private void picIBM_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = ("You clicked on the IBM Logo");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End Class
} // End namespace
