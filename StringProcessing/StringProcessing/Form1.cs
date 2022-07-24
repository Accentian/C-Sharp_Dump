using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringProcessing
{
    public partial class frmStringProcessing : Form
    {
        public frmStringProcessing()
        {
            InitializeComponent();
        }

        private void frmStringProcessing_Load(object sender, EventArgs e)
        {
            // IsAccessible digit
            string str = "12345";
            if (char.IsDigit(str, 0))
            {
                MessageBox.Show("There is a digit in position 0");
            } // End if

            // Is punctuation 
            string str1 = "Hello!";
            if (char.IsPunctuation(str1, 5))
            {
                MessageBox.Show("Hello! Has a punctuation at index 5");
            } // End if

            // Is lower 
            if (char.IsLower(str1, 1))
            {
                MessageBox.Show("Hello! Has a lower letter in position 1");
            } // End if

            // Contains
            string str2 = "Eat ice cream";
            if (str2.Contains("ice"))
            {
                MessageBox.Show("ice is in the string");
            } // End if

            // Starts with
            if (str2.StartsWith("Eat"))
            {
                MessageBox.Show("Eat starts in this string");
            } // End if

            // Ends with
            if (str2.EndsWith("eam"))
            {
                MessageBox.Show("eam ends in the string");
            } // End if

            // Position - returns -1 if not found
            string str3 = "chocolate ice cream";
            int position = str3.IndexOf("ice");
            if (position != -1)
            {
                MessageBox.Show("ice is found in position " + position.ToString());
            } // End if

            // Last index of
            string str4 = "blue green blue";
            position = str4.IndexOf("blue");
            if (position != -1)
            {
                MessageBox.Show("Last blue in position " + position.ToString());
            } // End if

            // Substring
            string str5 = "cocoa beans";
            MessageBox.Show(str5.Substring(0, 5));

            // Modifying strings
            string str6 = "New City";
            string str7 = str6.Insert(4, "York ");
            MessageBox.Show(str7);

            // Remove
            string str8 = "blueberry";
            string str9 = str8.Remove(4);
            MessageBox.Show(str9); // blue

            // Tokenizing 
            string str10 = "one two three four";
            String[] tokens = str10.Split(null);

            foreach( string word in tokens)
            {
                MessageBox.Show(word);
            } // End foreach



        } // End frmStringProcessing

    } // End class
} // End namespace
