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

namespace Chapter5Examples
{
    public partial class frmLoop : Form
    {
        public frmLoop()
        {
            InitializeComponent();
        }

        private void btnAddNumbers_Click(object sender, EventArgs e)
        {
            // Example of while loop
            int i = 1;
            while ( i <= 5) // Pretest
            {
                lstNumbers.Items.Add(i);
                i++;
            } // End while

        } // End btnAddNumbers

        private void btnBands_Click(object sender, EventArgs e)
        {
            // Do while loop
            int i = 1;
            do
            {
                lstBands.Items.Add("Rolling Stones");
                i++;
            } while (i <= 5); // Post test

        } // End btnBands click

        private void btnForLoop_Click(object sender, EventArgs e)
        {
            // Example of for loop
            // Used when you know exactly how many times to loop through
            for (int i = 10; i >= 1; i--)
            {
                lstNumbers.Items.Add(i);
            } // End for

        } // End btnForLoop Click

        private void btnFile_Click(object sender, EventArgs e)
        {
            // Example of writing to text file
            // Alt - Enter to import System IO for StreamWriter 
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("message.txt");
                outputFile.WriteLine("This is your message.");
                outputFile.Close();
            } // End try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // End catch

        } // End btnFile

        private void btnRandom_Click(object sender, EventArgs e)
        {
            // Example of using random number generator
            // Create instances of random
            Random rand = new Random();

            // Generate a number betwen 1 and 10
            int number = rand.Next(10) + 1;

            // Display number
            txtNumber.Text = number.ToString();

        } // End btnRandom

        private void btnFlip_Click(object sender, EventArgs e)
        {
            picDie.Image = Properties.Resources._1Die;
        } // End btnFlip

    } // End class
} // End namespace
