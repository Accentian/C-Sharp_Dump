using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSales
{
    public partial class frmTotalSales : Form
    {
        double total = 0;
        double average = 0;
        double largest = 0;
        double smallest = 0;

        public frmTotalSales()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Chapter 7.3 Example of reading files
            try
            {
                const int SIZE = 7;
                double[] numbers = new double[SIZE];

                int index = 0;
                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");

                while (index < numbers.Length && !inputFile.EndOfStream)
                {
                    numbers[index] = double.Parse(inputFile.ReadLine());

                    // Calculate the total of the sales
                    total += numbers[index];

                    index++;
                } // End while loop

                CalculateAverage(total, numbers);
                SalesLargest(numbers);
                SalesSmallest(numbers);

                // Close file
                inputFile.Close();

                foreach(double val in numbers)
                {
                    lstSales.Items.Add(val);
                } // End foreach loop

                txtTotal.Text = total.ToString();

            } // End try

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // End catch

        } // End btnCalculate

        private void CalculateAverage(double total, double[] numbers)
        {
            average = total / numbers.Length;
            txtAverage.Text = average.ToString("n2");

        } // End CalculateAverage

        private void SalesLargest(double[] numbers)
        {
            largest = numbers.Max();
            txtLargest.Text = largest.ToString();
        } // End SalesLargest

        private void SalesSmallest(double[] numbers)
        {
            smallest = numbers.Min();
            txtSmallest.Text = smallest.ToString();
        } // End SalesSmallest

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        } // End btnExit

    } // End class
} // End namespace
