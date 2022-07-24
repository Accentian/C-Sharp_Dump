using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class frmCalorieCounter : Form
    {
        double totalCalorie = 0;

        public frmCalorieCounter()
        {
            InitializeComponent();
        }

        private void picBananna_Click(object sender, EventArgs e)
        {
            double banannaCalorie = 115;
            totalCalorie = totalCalorie + banannaCalorie;
            txtCalorie.Text = totalCalorie.ToString();
        }

        private void picApple_Click(object sender, EventArgs e)
        {
            double appleCalorie = 80;
            totalCalorie = totalCalorie + appleCalorie;
            txtCalorie.Text = totalCalorie.ToString();
        }

        private void picOrange_Click(object sender, EventArgs e)
        {
            double orangeCalorie = 90;
            totalCalorie = totalCalorie + orangeCalorie;
            txtCalorie.Text = totalCalorie.ToString();
        }

        private void picPear_Click(object sender, EventArgs e)
        {
            double pearCalorie = 120;
            totalCalorie = totalCalorie + pearCalorie;
            txtCalorie.Text = totalCalorie.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            totalCalorie = 0;
            txtCalorie.Text = totalCalorie.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End Class
} // End namespace
