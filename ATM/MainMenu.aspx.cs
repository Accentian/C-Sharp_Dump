using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class MainMenu : System.Web.UI.Page
    {
        double balance = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtBalance.Text = Request.QueryString["Parameter"];
        }

        protected void txtBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            Response.Redirect("Withdraw.aspx?Parameter=" + balance);
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            Response.Redirect("Deposit.aspx?Parameter=" + balance);
        }
    } // End class
} // End namespace