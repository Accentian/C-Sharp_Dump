using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class Login : System.Web.UI.Page
    {
        double balance = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "Sommerfeltd" && txtPassword.Text == "Instructor")
            {
                balance = 1000.00;
                Response.Redirect("MainMenu.aspx?Parameter=" + balance);
            }
            else
            {
                txtStatus.Text = "Incorrect ID or Password, please try again.";
            }
        } // btnLogin
    } // End class
} // End namespace