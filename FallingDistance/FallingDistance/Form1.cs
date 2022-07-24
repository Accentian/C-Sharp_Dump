using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingDistance
{
    public partial class frmDistance : Form
    {
        public frmDistance()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
               double distance = 0;
               double seconds = double.Parse(txtTime.Text);

               FallingDistance(ref distance, seconds);

               txtMeters.Text = distance.ToString();
            }

            catch
            {
                MessageBox.Show("Please enter a number.");
            }
            
        } // End btnCalculate

        private double FallingDistance(ref double distance, double seconds)
        {
            double gravity = 9.8;

            distance = 0.5 * gravity * Math.Pow(seconds, 2);

            return distance;

        } // End FallingDistance

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End class
} // End namespace
