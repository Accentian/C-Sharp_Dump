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
    public partial class VirtualTemperature : Form
    {
        public VirtualTemperature()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double vt = WeatherLibrary.WeatherFunction.VirtualTemperature
                     (Convert.ToDouble(txtCel.Text),
                     Convert.ToDouble(txtVP.Text),
                     Convert.ToDouble(txtSP.Text));

                txtResult.Text = vt.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid number");
            }
        } // End calculate
    } // End class
} // End namespace
