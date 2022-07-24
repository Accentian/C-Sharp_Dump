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
    public partial class MixingRatio : Form
    {
        public MixingRatio()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
               double MX = WeatherLibrary.WeatherFunction.MixingRatio
                    (Convert.ToDouble(txtPressure.Text), 
                    Convert.ToDouble(txtVaporPressure.Text));

                txtResults.Text = MX.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End Calculate
    } // End Class
} // End Namespace
