using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WheelOfFortune
{
    public partial class Spin : Form
    {
        public Spin()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            bool singleChar = false;
            char letter;

            if (txtLetter.Text != "")
            {
                singleChar = true;

                if (singleChar = true && Char.IsLetter(Char.Parse(txtLetter.Text)))
                {
                    letter = Char.ToUpper(char.Parse(txtLetter.Text));
                    // If letter is correct, something true, add amount on Form1?
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a letter.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a letter.");
            }

            

        } // End btnChoose

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End class
} // End namespace
