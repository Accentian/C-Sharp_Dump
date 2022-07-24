using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesPerGallon
{
    public partial class frmMilesPerGallon : Form
    {
        public frmMilesPerGallon()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                // Declare Variables
                double miles = 0;
                double gallons = 0;
                double mpg = 0;

                // Get inputs - miles and gallons
                miles = double.Parse(boxMiles.Text);
                gallons = double.Parse(boxGallons.Text);

                // Calculate
                mpg = miles / gallons;

                // Display answer
                txtMPG.Text = mpg.ToString("n2");

            } // End try

            catch
            {
                MessageBox.Show("Invalid data was entered. Please enter again.");
                boxMiles.Text = "";
                boxGallons.Text = "";
                boxMiles.Focus();
            } // End catch

        } // End Calculate_Click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    } // End class
} // End Namespace
