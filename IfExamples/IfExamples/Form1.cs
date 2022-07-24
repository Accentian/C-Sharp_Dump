using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfExamples
{
    public partial class frmIfExamples : Form
    {
        public frmIfExamples()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables
                double test1, test2, avg;
                const double GREAT_SCORE = 95.0;
                const double GOOD_SCORE = 80.0;

                // Get values from textboxes
                test1 = double.Parse(txtTest1.Text);
                // Use and/or example
                if (test1 < 0 || test1 > 100)
                {
                    MessageBox.Show("Out of range.");
                }

                test2 = double.Parse(txtTest2.Text);
                if (test2 < 0 || test2 > 100)
                {
                    MessageBox.Show("Out of range.");
                }

                // Calculate average
                avg = (test1 + test2) / 2;

                // Display answer
                txtAverage.Text = avg.ToString("n1");

                // If statements
                if (avg >= GREAT_SCORE)
                {
                    MessageBox.Show("Great Score!");
                } // End If
                else if (avg >= GOOD_SCORE)
                {
                    MessageBox.Show("Good Score.");
                } // End Else If
                else
                {
                    MessageBox.Show("Needs more work.");
                } // End Else

            } // End try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            } // End catch



        } // End btnCcalc

    } // End Class
} // End namespace
