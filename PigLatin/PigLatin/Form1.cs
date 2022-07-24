using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatin
{
    public partial class frmPigLatin : Form
    {
        // Global variables
        const string latin = "ay";
        string sentence;
        string translation;
        int wordCount = 0;
        int vowelsCount = 0;

        public frmPigLatin()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            // Create variable for vowels
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            

            try
            {
                // Get sentence or word from user
                sentence = txtEnter.Text.ToLower();

                // Count the words
                foreach(var word in sentence)
                {
                    wordCount = sentence.Trim().Split(' ').Count();
                } // End foreach

                // Display word count
                txtCount.Text = wordCount.ToString();



                // Find and count vowels
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (vowels.Contains(sentence[i]))
                    {
                        vowelsCount++;
                    } // End if
                } // End for

                // Display vowels
                txtVowels.Text = vowelsCount.ToString();



                // Translation
                // Issue: Need to do more research and search for references
                string[] translate = sentence.Split(' ');

                for(int i = 0; i < translate.Length; i++)
                {
                    // Method, referenced from external sources and textbook
                    translation += getTranslation(translate[i]);
                } // End for

                // Display translation, external references used for Environment.NewLine
                txtTranslation.Text = translation + Environment.NewLine;

            } // End try



            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            } // End catch



        } // End btnTranslate

        private string getTranslation(string sentence)
        {
            string word;
            string first = sentence.Substring(0, 1);

            word = sentence.Substring(1) + first + latin + " ";

            return word;
        } // End getTranslation

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEnter.Text = "";
            sentence = txtEnter.Text;

            txtTranslation.Text = "";
            translation = txtTranslation.Text;

            wordCount = 0;
            txtCount.Text = wordCount.ToString();

            vowelsCount = 0;
            txtVowels.Text = vowelsCount.ToString();
            
        } // End btnClear
    } // End class
} // End namespace
