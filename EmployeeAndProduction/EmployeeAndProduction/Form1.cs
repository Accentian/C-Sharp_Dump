using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAndProduction
{
    public partial class frmProduction : Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (radYes.Checked)
            {
                ShiftSupervisor sup = new ShiftSupervisor();

                // Set name and number
                sup.Name = txtName.Text;
                sup.Number = txtNumber.Text;

                // Set annual salary and bonus
                sup.AnnualSalary = Convert.ToDouble(txtSalary.Text);
                sup.AnnualBonus = Convert.ToDouble(txtBonus.Text);

                // Show object
                MessageBox.Show("Employee: " + sup.Name + "\n"
                    + "Employee ID: " + sup.Number + "\n"
                    + "Annual Salary: " + sup.AnnualSalary + "\n"
                    + "Annual Production Bonus: " + sup.AnnualBonus);

            } // End radYes checked

            else
            {
                ProductionWorker pro = new ProductionWorker();

                // Set name and number
                pro.Name = txtName.Text;
                pro.Number = txtNumber.Text;

                // Set shift and pay rate
                pro.Shift = Convert.ToInt32(txtShift.Text);
                pro.PayRate = Convert.ToDouble(txtPayRate.Text);

                // Show object
                MessageBox.Show("Employee: " + pro.Name + "\n"
                    + "Employee ID: " + pro.Number + "\n"
                    + "Shift Number: " + pro.Shift + "\n"
                    + "Hourly Pay Rate: " + pro.PayRate);

            } // End else

        } // End btnDisplay

        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            txtSalary.Visible = radYes.Checked;
            lblSalary.Visible = radYes.Checked;

            txtBonus.Visible = radYes.Checked;
            lblBonus.Visible = radYes.Checked;

            txtPayRate.Visible = radNo.Checked;
            lblPayRate.Visible = radNo.Checked;

            txtShift.Visible = radNo.Checked;
            lblShift.Visible = radNo.Checked;
        } // End radYes

        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            txtPayRate.Visible = radNo.Checked;
            lblPayRate.Visible = radNo.Checked;

            txtShift.Visible = radNo.Checked;
            lblShift.Visible = radNo.Checked;

            txtSalary.Visible = radYes.Checked;
            lblSalary.Visible = radYes.Checked;

            txtBonus.Visible = radYes.Checked;
            lblBonus.Visible = radYes.Checked;
        } // End radNo
    } // End class
} // End namespace
