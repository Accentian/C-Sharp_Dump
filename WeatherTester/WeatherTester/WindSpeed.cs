using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherTester
{
    public partial class WindSpeed : Form
    {
        public WindSpeed()
        {
            InitializeComponent();
        }

        private void btnConvertKnots_Click(object sender, EventArgs e)
        {
            try
            {
                double mph = WeatherLibrary.WeatherFunction.knotsToMPH
                     (Convert.ToDouble(txtKnots.Text));

                txtMPHResults.Text = mph.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End ConvertKnots

        private void btnConvertMPH_Click(object sender, EventArgs e)
        {
            try
            {
                double knots = WeatherLibrary.WeatherFunction.mphToKnots
                     (Convert.ToDouble(txtMPH.Text));

                txtKnotsResults.Text = knots.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End ConvertMPH
    } // End class
} // End namespace
