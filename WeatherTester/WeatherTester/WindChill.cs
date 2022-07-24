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
    public partial class WindChill : Form
    {
        public WindChill()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double wc = WeatherLibrary.WeatherFunction.WindChill
                     (Convert.ToDouble(txtFahr.Text),
                     Convert.ToDouble(txtMPH.Text));

                txtResult.Text = wc.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }

        } // End calculate
    } // End class
} // End namespace
