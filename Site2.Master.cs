using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace OrderManagementSystem
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = "WELCOME" + " " + Request.Cookies["userid"].Value.ToString();
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            
            FormsAuthentication.SignOut();
            Response.Redirect("Homepage.aspx");
        }
    }
}