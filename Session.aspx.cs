using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["onlineUsers"] == null)
        {
            Session["onlineUsers"] = 0;  // Initialize session variable if it's the first user
        }

        // Increment online users count on each page load
        Session["onlineUsers"] = (int)Session["onlineUsers"] + 1;

        // Display number of online users
        lblOnlineUsers.Text = "Online Users: " + Session["onlineUsers"].ToString();
    }
}

// In your ASPX code-behind file (e.g., Default.aspx.cs)


