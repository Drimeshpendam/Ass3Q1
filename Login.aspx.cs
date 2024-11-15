using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        // Check if the username and password exist in the database
        string connStr = "your_connection_string_here";
        string query = "SELECT Role FROM UserLogin WHERE UserName=@Username AND Password=@Password";

        using (SqlConnection conn = new SqlConnection(connStr))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            conn.Open();
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                // Login success, create a cookie with the role
                HttpCookie loginCookie = new HttpCookie("LoginInfo");
                loginCookie["Username"] = username;
                loginCookie["Role"] = result.ToString();
                loginCookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(loginCookie);

                // Redirect based on role
                if (result.ToString() == "Admin")
                    Response.Redirect("admin.aspx");
                else if (result.ToString() == "Faculty")
                    Response.Redirect("faculty.aspx");
                else if (result.ToString() == "Clerk")
                    Response.Redirect("clerk.aspx");
            }
            else
            {
                lblError.Text = "Invalid login credentials.";
            }
        }
    }


}

