using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab9
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            string cs = ConfigurationManager.ConnectionStrings["UserDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                con.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Session["Username"] = username;
                    Response.Redirect("Welcome.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid Username or Password!";
                }
            }
        }
    }
}