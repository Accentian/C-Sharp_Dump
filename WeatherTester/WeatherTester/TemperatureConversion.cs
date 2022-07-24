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
    public partial class TemperatureConversion : Form
    {
        public TemperatureConversion()
        {
            InitializeComponent();
        }

        private void btnConFahr_Click(object sender, EventArgs e)
        {
            try
            {
                double fahr = WeatherLibrary.WeatherFunction.CelToFahr
                     (Convert.ToDouble(txtCelToFahr.Text));

                txtResultFahr.Text = fahr.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End

        private void btnConKel_Click(object sender, EventArgs e)
        {
            try
            {
                double kel = WeatherLibrary.WeatherFunction.CelToKel
                     (Convert.ToDouble(txtCelToKel.Text));

                txtResultKel.Text = kel.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End

        private void btnConCel_Click(object sender, EventArgs e)
        {
            try
            {
                double cel = WeatherLibrary.WeatherFunction.FahrToCel
                     (Convert.ToDouble(txtFahrToCel.Text));

                txtResultCel.Text = cel.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End

        private void btnConKel2_Click(object sender, EventArgs e)
        {
            try
            {
                double kel2 = WeatherLibrary.WeatherFunction.FahrToKel
                     (Convert.ToDouble(txtFahrToKel.Text));

                txtResultKel2.Text = kel2.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End

    } // End class
} // End namespace
