using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Declare array
            const int ROWS = 3;
            const int COLS = 3;
            int[,] board = new int[ROWS, COLS];

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    board[row, col] = rand.Next(2);
                } // End nested for loop
            } // End for loop

            // First row
            if (board[0, 0] == 0){
                box00.Image = Properties.Resources.o;
            }
            else if (board[0, 0] == 1)
            {
                box00.Image = Properties.Resources.x;
            }

            if (board[0, 1] == 0)
            {
                box01.Image = Properties.Resources.o;
            }
            else if (board[0, 1] == 1)
            {
                box01.Image = Properties.Resources.x;
            }

            if (board[0, 2] == 0)
            {
                box02.Image = Properties.Resources.o;
            }
            else if (board[0, 2] == 1)
            {
                box02.Image = Properties.Resources.x;
            }
            // End of First row

            // Second row
            if (board[1, 0] == 0)
            {
                box10.Image = Properties.Resources.o;
            }
            else if (board[1, 0] == 1)
            {
                box10.Image = Properties.Resources.x;
            }

            if (board[1, 1] == 0)
            {
                box11.Image = Properties.Resources.o;
            }
            else if (board[1, 1] == 1)
            {
                box11.Image = Properties.Resources.x;
            }

            if (board[1, 2] == 0)
            {
                box12.Image = Properties.Resources.o;
            }
            else if (board[1, 2] == 1)
            {
                box12.Image = Properties.Resources.x;
            }
            // End of Second row

            // Third row
            if (board[2, 0] == 0)
            {
                box20.Image = Properties.Resources.o;
            }
            else if (board[2, 0] == 1)
            {
                box20.Image = Properties.Resources.x;
            }

            if (board[2, 1] == 0)
            {
                box21.Image = Properties.Resources.o;
            }
            else if (board[2, 1] == 1)
            {
                box21.Image = Properties.Resources.x;
            }

            if (board[2, 2] == 0)
            {
                box22.Image = Properties.Resources.o;
            }
            else if (board[2, 2] == 1)
            {
                box22.Image = Properties.Resources.x;
            }
            // End of Third row

            // Search and Display winner
            // Check rows
            if (board[0, 0] == 0 && board[0, 1] == 0 && board[0, 2] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else if (board[1, 0] == 0 && board[1, 1] == 0 && board[1, 2] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else if (board[2, 0] == 0 && board[2, 1] == 0 && board[2, 2] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            // Check columns
            else if (board[0, 0] == 0 && board[1, 0] == 0 && board[2, 0] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else if (board[0, 1] == 0 && board[1, 1] == 0 && board[2, 1] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else if (board[0, 2] == 0 && board[1, 2] == 0 && board[2, 2] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            // check diags
            else if (board[0, 0] == 0 && board[1, 1] == 0 && board[2, 2] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else if (board[0, 2] == 0 && board[1, 1] == 0 && board[2, 0] == 0)
            {
                txtWinner.Text = ("O Wins!");
            }
            else if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                txtWinner.Text = ("X Wins!");
            } // End

            else
            {
                txtWinner.Text = ("Tie!");
            } // End Else Statement - Tie!

        } // End btnNew

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } // End class
} // End namespace
