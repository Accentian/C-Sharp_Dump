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

namespace DiceSimulator
{
    public partial class frmDice : Form
    {
        int win = 0;
        int lost = 0;
        int tie = 0;

        public frmDice()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Generate random numbers
            Random rand = new Random();

            // Player's dice
            int pRoll1 = rand.Next(6) + 1;
            int pRoll2 = rand.Next(6) + 1;

            // CPU's dice
            int cRoll1 = rand.Next(6) + 1;
            int cRoll2 = rand.Next(6) + 1;

            // Calculation
            int playerTotal = pRoll1 + pRoll2;
            int cpuTotal = cRoll1 + cRoll2;

            // Else If statements to calculate win, lost, and tie
            if (playerTotal > cpuTotal)
            {
                win = win + 1;
                txtWin.Text = win.ToString();
            } // End if

            else if (playerTotal < cpuTotal)
            {
                lost = lost + 1;
                txtLost.Text = lost.ToString();
            } // End else if

            else
            {
                tie = tie + 1;
                txtTie.Text = tie.ToString();
            } // End else

            // Four series of switch statements to change the image of the dice
            switch (pRoll1)
            {
                case 1:
                    picDieP1.Image = Properties.Resources._1Die;
                    break;

                case 2:
                    picDieP1.Image = Properties.Resources._2Die;
                    break;

                case 3:
                    picDieP1.Image = Properties.Resources._3Die;
                    break;

                case 4:
                    picDieP1.Image = Properties.Resources._4Die;
                    break;

                case 5:
                    picDieP1.Image = Properties.Resources._5Die;
                    break;

                case 6:
                    picDieP1.Image = Properties.Resources._6Die;
                    break;

            } // End switch

            switch (pRoll2)
            {
                case 1:
                    picDieP2.Image = Properties.Resources._1Die;
                    break;

                case 2:
                    picDieP2.Image = Properties.Resources._2Die;
                    break;

                case 3:
                    picDieP2.Image = Properties.Resources._3Die;
                    break;

                case 4:
                    picDieP2.Image = Properties.Resources._4Die;
                    break;

                case 5:
                    picDieP2.Image = Properties.Resources._5Die;
                    break;

                case 6:
                    picDieP2.Image = Properties.Resources._6Die;
                    break;

            } // End switch

            switch (cRoll1)
            {
                case 1:
                    picDieC1.Image = Properties.Resources._1Die;
                    break;

                case 2:
                    picDieC1.Image = Properties.Resources._2Die;
                    break;

                case 3:
                    picDieC1.Image = Properties.Resources._3Die;
                    break;

                case 4:
                    picDieC1.Image = Properties.Resources._4Die;
                    break;

                case 5:
                    picDieC1.Image = Properties.Resources._5Die;
                    break;

                case 6:
                    picDieC1.Image = Properties.Resources._6Die;
                    break;

            } // End switch

            switch (cRoll2)
            {
                case 1:
                    picDieC2.Image = Properties.Resources._1Die;
                    break;

                case 2:
                    picDieC2.Image = Properties.Resources._2Die;
                    break;

                case 3:
                    picDieC2.Image = Properties.Resources._3Die;
                    break;

                case 4:
                    picDieC2.Image = Properties.Resources._4Die;
                    break;

                case 5:
                    picDieC2.Image = Properties.Resources._5Die;
                    break;

                case 6:
                    picDieC2.Image = Properties.Resources._6Die;
                    break;

            } // End switch
        } // End btnRoll

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter gameResult;
                gameResult = File.CreateText("game_result.txt");
                gameResult.WriteLine("Wins: " + win);
                gameResult.WriteLine("Loses: " + lost);
                gameResult.WriteLine("Ties: " + tie);
                gameResult.Close();

                // Display a message as well
                MessageBox.Show("Wins: " + win + "\n" 
                    + "Loses: " + lost + "\n" 
                    + "Ties: " + tie);

            } // End try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } // End catch

            this.Close();

        } // End btnEnd
    } // End class
} // End namespace
