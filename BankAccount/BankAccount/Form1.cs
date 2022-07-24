using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class frmBank : Form
    {
        public frmBank()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit dep1 = new Deposit(500.00);
            Deposit dep2 = new Deposit();

            double newBalance1 = dep1.calcBalance(Convert.ToDouble(txtAmount1.Text), 
                (Convert.ToDouble(txtAmount2.Text)));

            MessageBox.Show(newBalance1.ToString());

            double newBalance2 = dep2.calcBalance(Convert.ToDouble(txtAmount1.Text),
                (Convert.ToDouble(txtAmount2.Text)));

            MessageBox.Show(newBalance2.ToString());


        } // End btnDeposit

        private void btnPage2_Click(object sender, EventArgs e)
        {
            // Create Page2
            Page2 secondPage = new Page2();
            secondPage.txtMessage.Text = "Hello";
            secondPage.Show();

            
            


        } // End btnPage2
    } // End class
} // End namespace
