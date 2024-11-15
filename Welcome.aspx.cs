using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie userCookie = Request.Cookies["UserInfo"];

        if (userCookie != null)
        {
            string username = userCookie["Username"];
            string color = userCookie["Color"];

            // Display welcome message with selected color
            lblWelcome.Text = "Welcome " + username;
            lblWelcome.ForeColor = System.Drawing.Color.FromName(color);
        }
        else
        {
            lblWelcome.Text = "No user information found in cookies.";
        }
    }

}