using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritanceExample
{
    public partial class frmInheritance : Form
    {
        public frmInheritance()
        {
            InitializeComponent();
        }

        private void radFaculty_CheckedChanged(object sender, EventArgs e)
        {
            txtDevHours.Visible = radFaculty.Checked;
            lblDevHours.Visible = radFaculty.Checked;

            txtCommittees.Visible = radFaculty.Checked;
            lblCommittees.Visible = radFaculty.Checked;

            txtWorkshopHours.Visible = radStaff.Checked;
            lblWorkshopHours.Visible = radStaff.Checked;

            txtFlexSpending.Visible = radStaff.Checked;
            lblFlexSpending.Visible = radStaff.Checked;

        } // End radFaculty

        private void radStaff_CheckedChanged(object sender, EventArgs e)
        {
            txtDevHours.Visible = radFaculty.Checked;
            lblDevHours.Visible = radFaculty.Checked;

            txtCommittees.Visible = radFaculty.Checked;
            lblCommittees.Visible = radFaculty.Checked;

            txtWorkshopHours.Visible = radStaff.Checked;
            lblWorkshopHours.Visible = radStaff.Checked;

            txtFlexSpending.Visible = radStaff.Checked;
            lblFlexSpending.Visible = radStaff.Checked;

        } // End radStaff

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (radFaculty.Checked)
            {
                Faculty fac = new Faculty();

                // Set name and address
                fac.Name = txtName.Text;
                fac.Address = txtAddress.Text;

                // Set professional dev hours and committees
                fac.ProfessionalDevHrs = Convert.ToDouble(txtDevHours.Text);
                fac.Committees = txtCommittees.Text;

                // Show object
                MessageBox.Show(fac.Name + " lives at " + fac.Address + " has "
                    + fac.ProfessionalDevHrs + " hours and serves on " 
                    + fac.Committees + " committees");

            } // End Faculty is checked

            else
            {
                Staff sta = new Staff();

                // Set name and address
                sta.Name = txtName.Text;
                sta.Address = txtAddress.Text;

                // Set professional dev hours and committees
                sta.WorkShopHrs = Convert.ToDouble(txtWorkshopHours.Text);
                sta.FlexSpending = Convert.ToDouble(txtFlexSpending.Text);

                // Show object
                MessageBox.Show(sta.Name + " lives at " + sta.Address + " has "
                    + sta.WorkShopHrs + " hours and has an amount of "
                    + sta.FlexSpending);

            } // End else statement

        } // End btnCreate
    } // End class
} // End namespace
