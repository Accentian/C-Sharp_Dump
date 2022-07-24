using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoDimExample
{
    public partial class frmDim : Form
    {
        public frmDim()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            // Declare array
            const int ROWS = 2;
            const int COLS = 3;
            int[,] grades = new int[ROWS, COLS];

            grades[0, 0] = Convert.ToInt16(txtS1G1.Text);
            grades[0, 1] = Convert.ToInt16(txtS1G2.Text);
            grades[0, 2] = Convert.ToInt16(txtS1G3.Text);

            grades[1, 0] = Convert.ToInt16(txtS2G1.Text);
            grades[1, 1] = Convert.ToInt16(txtS2G2.Text);
            grades[1, 2] = Convert.ToInt16(txtS2G3.Text);

            // Put grades into listbox
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    lstGrades.Items.Add("Student " + (row + 1) + "  " + grades[row, col].ToString());
                } // End nested for loop
            } // End for loop

            // List Array - more dynamic
            List<int> numbers = new List<int>();
            // Add values to our list array
            numbers.Add(Convert.ToInt16(txtS1G1.Text));
            numbers.Add(Convert.ToInt16(txtS1G2.Text));
            numbers.Add(Convert.ToInt16(txtS1G3.Text));

            numbers.Add(Convert.ToInt16(txtS2G1.Text));
            numbers.Add(Convert.ToInt16(txtS2G2.Text));
            numbers.Add(Convert.ToInt16(txtS2G3.Text));

            //Show value in message box
            for (int i = 0; i < numbers.Count; i++)
            {
                MessageBox.Show(numbers[i].ToString());

            } // End for loop

        } // End btnGrade

    } // End class
} // End namespace
