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
    public partial class RelativeHumidity : Form
    {
        public RelativeHumidity()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double RH = WeatherLibrary.WeatherFunction.RelativeHumidity
                     (Convert.ToDouble(txtActVapor.Text),
                     Convert.ToDouble(txtSatVapor.Text));

                txtHumidity.Text = RH.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End calculate
    } // End class
} // End namespace
