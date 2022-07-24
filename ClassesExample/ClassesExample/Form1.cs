using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesExample
{
    public partial class frmExample : Form
    {
        public frmExample()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            // Create an instance of the Coin class
            Coin myCoin = new Coin("Heads");

            // Toss our coin
            myCoin.toss();

            // Put toss in our label
            lblToss.Text = myCoin.getToss();

        } // End btnToss

        private void btnProperty_Click(object sender, EventArgs e)
        {
            // Create a second instance of Coin
            Coin myCoin2 = new Coin("Heads");

            // Call property
            myCoin2.Flip = "Side opposite of your call";
            MessageBox.Show(myCoin2.Flip);

        } // End btnProperty
    } // End class
} // End namespace
