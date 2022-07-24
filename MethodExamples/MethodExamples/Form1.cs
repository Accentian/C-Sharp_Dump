using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodExamples
{
    public partial class frmMethod : Form
    {
        public frmMethod()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayMessage();
            DisplayMessage2("This is your second message.", 2);
        } // End btnDisplay


        // Write our own method
        private void DisplayMessage()
        {
            MessageBox.Show("Hello World.");
        } // End DisplayMessage


        // Method to accept argument
        private void DisplayMessage2(string message, int rating)
        {
            MessageBox.Show(message);

            if (rating == 1)
            {
                MessageBox.Show("I enjoy this class.");
            }
            else if (rating == 2)
            {
                MessageBox.Show("I need more sleep.");
            }
            else
            {
                MessageBox.Show("Lights out.");
            }
        } // End DisplayMessage2

        private void btnShowMax_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            ShowMaxNumber( ref num1, num2);

            MessageBox.Show(Convert.ToString(num1));

        } // End btnShowMax

        private void ShowMaxNumber(ref int num1, int num2)
        {
            if (num1 > num2)
            {
                MessageBox.Show("Bigger number is " + num1);
            }
            else
            {
                MessageBox.Show("Bigger number is " + num2);
            }
            
            // Use ref value to make num1 a single variable. Now num1 will show up as 99999
            num1 = 99999;
        } // End ShowMaxNumber

        private void btnShowMin_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            // Need to store the numbers
            int min = ShowMinNumber(num1, num2);

            MessageBox.Show("Lower number is " + min);
            
        } // End btnShowMin

        private int ShowMinNumber(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        } // End ShowminNumber

    } // End class
} // End namespace
