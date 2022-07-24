using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class Withdraw : System.Web.UI.Page
    {
        public double balance = 0;
        public double withdraw = 0;

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

        protected void txtBalance_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            withdraw = Convert.ToDouble(txtWithdraw.Text);
            try
            {
                if (withdraw > balance || withdraw < 0)
                {
                    txtStatus.Text = "Withdraw amount cannot exceed the current balance, " +
                        "or be less than $0";
                }
                else
                {
                    balance -= withdraw;
                    txtBalance.Text = balance.ToString();

                    txtStatus.Text = "";
                }
            }
            catch
            {
                txtStatus.Text = "Please enter a number.";
            }

        } // End btnWithdraw

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            balance = Convert.ToDouble(txtBalance.Text);
            Response.Redirect("MainMenu.aspx?Parameter=" + balance.ToString());
        }
    } // End class
} // End namespace