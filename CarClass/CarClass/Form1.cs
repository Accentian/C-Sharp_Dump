using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarClass
{
    public partial class frmCar : Form
    {

        public frmCar()
        {
            InitializeComponent();
        }

        private void btnAccel_Click(object sender, EventArgs e)
        {
            // Create instance of Car Class, C# suggested simpification
            Car carAccel = new Car
            {
                Speed = double.Parse(txtSpeed.Text)
            };

            double accelSpeed = carAccel.Accelerate(Convert.ToDouble(txtSpeed.Text));

            txtSpeed.Text = accelSpeed.ToString();

        } // End btnAccel

        private void btnBrake_Click(object sender, EventArgs e)
        {
            // Create instance of Car Class, C# suggested simpification
            Car carBrake = new Car
            {
                Speed = double.Parse(txtSpeed.Text)
            };

            double brakeSpeed = carBrake.Brake(Convert.ToDouble(txtSpeed.Text));

            txtSpeed.Text = brakeSpeed.ToString();

        } // End btnBrake

        private void btnDetail_Click(object sender, EventArgs e)
        {
            // Create another instances
            Car myCar = new Car();

            // Create Detail page
            YearAndMake detail = new YearAndMake();
            detail.txtYear.Text = myCar.Year;
            detail.txtMake.Text = myCar.Make;

            detail.Show();

        } // End btnForm
    } // End class
} // End namespace
