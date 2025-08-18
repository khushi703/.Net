using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Login
{
    public partial class WebForm1 : Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                
                string query = "SELECT COUNT(*) FROM Users WHERE Username = '" + username + "' AND Password = '" + password + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    Session["Username"] = username;
                    lblStatus.Text = "✅ Login successful!";
                }
                else
                {
                    lblStatus.Text = "❌ Invalid username or password.";
                }
            }
        }
    }
}
