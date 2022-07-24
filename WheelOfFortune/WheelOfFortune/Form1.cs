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
    public partial class frmWheelOfFortune : Form
    {
        public frmWheelOfFortune()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            // Declare Array
            const int SIZE = 3;
            int[] PlayerAmount = new int[SIZE];

            PlayerAmount[0] = 0;
            PlayerAmount[1] = 0;
            PlayerAmount[2] = 0;
            
            // Create instances of Spin
            Spin spinPage = new Spin();

            // Create "spin" using Random
            Random rand = new Random();
            int spinLand = rand.Next(10);

            int amount = 0;
            int player = 0;

            if (spinLand == 0)
            {
                spinPage.txtLand.Text = "$100";
                amount = 100;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 1)
            {
                spinPage.txtLand.Text = "$300";
                amount = 300;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 2)
            {
                spinPage.txtLand.Text = "$500";
                amount = 500;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 3)
            {
                spinPage.txtLand.Text = "$700";
                amount = 700;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 4)
            {
                spinPage.txtLand.Text = "$900";
                amount = 900;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 5)
            {
                spinPage.txtLand.Text = "$2000";
                amount = 2000;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 6)
            {
                spinPage.txtLand.Text = "$3000";
                amount = 3000;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 7)
            {
                spinPage.txtLand.Text = "$5000";
                amount = 5000;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 8)
            {
                // Lose a Turn as well
                spinPage.txtLand.Text = "-$1000";
                amount = -1000;

                spinPage.txtLetter.Visible = false;
                spinPage.lblLetter.Visible = false;
                spinPage.btnChoose.Visible = false;
                spinPage.btnOkay.Visible = true;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }
            else if (spinLand == 9)
            {
                spinPage.txtLand.Text = "Lose a Turn";
                amount = 0;

                spinPage.txtLetter.Visible = false;
                spinPage.lblLetter.Visible = false;
                spinPage.btnChoose.Visible = false;
                spinPage.btnOkay.Visible = true;
                if (player > 2)
                {
                    player = 0;
                    AddAmount(player, amount);
                }
                else
                {
                    AddAmount(player, amount);
                }
            }

            player++;

            // Change Modifiers for the elements in spinPage to be Public
            spinPage.lblLettersLeft.Text = lblLetters.Text;

            spinPage.Show();
        } // End btnSpin

        private void AddAmount(int i, int amount)
        {
            
        } // End AddAmount

    } // End class
} // End namespace
