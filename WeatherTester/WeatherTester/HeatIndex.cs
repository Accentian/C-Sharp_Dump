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
    public partial class HeatIndex : Form
    {
        public HeatIndex()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double hi = WeatherLibrary.WeatherFunction.HeatIndex
                     (Convert.ToDouble(txtCelcius.Text),
                     Convert.ToDouble(txtPercent.Text));

                txtResults.Text = hi.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End calculate
    } // End class
} // End namespace
