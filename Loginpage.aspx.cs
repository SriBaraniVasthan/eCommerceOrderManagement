using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace OrderManagementSystem
{
    public partial class Loginpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(FormsAuthentication.Authenticate(txtUserID.Text.Trim(),txtPassword.Text.Trim()))
            {
                Response.Cookies["userid"].Value = txtUserID.Text;
                Response.Redirect("PlaceOrder.aspx");
            }

        }
    }
}