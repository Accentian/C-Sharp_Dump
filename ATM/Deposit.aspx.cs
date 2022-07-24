using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class Deposit : System.Web.UI.Page
    {
        public double balance = 0;
        public double deposit = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            bool hasUserVisitedPage = false;
            string pagePath = HttpContext.Current.Request.Url.LocalPath;

            try { hasUserVisitedPage = (bool)HttpContext.Current.Session[pagePath]; }
            catch { }

            if (!hasUserVisitedPage)
            {
                HttpContext.Current.Session[pagePath] = true;

                txtBalance.Text = Request.QueryString["Parameter"];
                balance = Convert.ToDouble(txtBalance.Text);
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            deposit = Convert.ToDouble(txtDeposit.Text);
            try
            {
                if (deposit < 0)
                {
                    txtStatus.Text = "Deposit amount cannot be less than $0";
                }
                else
                {
                    balance += deposit;
                    txtBalance.Text = balance.ToString();

                    txtStatus.Text = "";
                }
            }
            catch
            {
                txtStatus.Text = "Please enter a number.";
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            Response.Redirect("MainMenu.aspx?Parameter=" + balance.ToString());
        }
    } // End class
} // End namespace