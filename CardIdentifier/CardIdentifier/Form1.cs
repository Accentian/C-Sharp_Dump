using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void nineDiamonds_Click(object sender, EventArgs e)
        {
            txtCardType.Text = ("Nine of Diamonds");
        }

        private void spadesAce_Click(object sender, EventArgs e)
        {
            txtCardType.Text = ("Ace of Spades");
        }

        private void redJoker_Click(object sender, EventArgs e)
        {
            txtCardType.Text = ("Joker");
        }

        private void fourClubs_Click(object sender, EventArgs e)
        {
            txtCardType.Text = ("Four of Clubs");
        }

        private void queenHearts_Click(object sender, EventArgs e)
        {
            txtCardType.Text = ("Queen of Hearts");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
