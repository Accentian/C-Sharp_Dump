using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtName.Text + ", you're a long way from home.";
        } // End btnDisplay

        protected void btnSecond_Click(object sender, EventArgs e)
        {
            Response.Redirect("second.aspx");
        } // End btnSecond
    } // End class
} // End namespace