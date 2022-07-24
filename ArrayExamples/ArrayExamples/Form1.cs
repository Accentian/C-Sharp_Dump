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

namespace ArrayExamples
{
    public partial class frmArray : Form
    {
        public frmArray()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            const int SIZE = 3;
            int[] numbersArray = new int[SIZE];
            numbersArray[0] = 90;
            numbersArray[1] = 100;
            numbersArray[2] = 80;

            // Another way to write 3 lines above
            int[] numberArray1 = { 90, 100, 80 };

            // Put numbers in the labels
            lblIndex0.Text = numbersArray[0].ToString();
            lblIndex1.Text = numbersArray[1].ToString();
            lblIndex2.Text = numbersArray[2].ToString();

            // Average of array, For Loop for array
            int total = 0;
            for(int index = 0; index < numbersArray.Length; index++)
            {
                total += numbersArray[index];

            } // End for

            double avg = total / numbersArray.Length;
            lblAverage.Text = avg.ToString();

            // For each loop
            foreach(int val in numbersArray)
            {
                MessageBox.Show(val.ToString());
            } // End foreach

            // Using for loop to write to file, Alt-Enter StreamWriter
            StreamWriter outputFile;
            outputFile = File.CreateText("grades.txt");

            for(int i = 0; i < numbersArray.Length; i++) 
            {
                outputFile.WriteLine(numbersArray[i]);
            } // End for

            outputFile.Close();


        } // End btnShow

        private void btnPassing_Click(object sender, EventArgs e)
        {
            string[] people = { "Bill", "Jill", "Phil", "Will" };
            ShowPeople(people);


        } // End btnPassing

        private void ShowPeople(string[] strArray)
        {
            foreach(string str in strArray)
            {
                MessageBox.Show(str);
            } // End foreach

        } // End ShowPeople

    } // End class
} // End namespace
