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
    public partial class VolumnRainfall : Form
    {
        public VolumnRainfall()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double VR = WeatherLibrary.WeatherFunction.VolumnRainfall
                     (Convert.ToDouble(txtArea.Text),
                     Convert.ToDouble(txtHeight.Text));

                txtVolumn.Text = VR.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End Calculate
    } // End class
} // End namespace
