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
    public partial class DewPoint : Form
    {
        public DewPoint()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double dp = WeatherLibrary.WeatherFunction.DewPoint
                     (Convert.ToDouble(txtFahr.Text),
                     Convert.ToDouble(txtRH.Text));

                txtResults.Text = dp.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End Calculate
    } // End class
} // End namespace
