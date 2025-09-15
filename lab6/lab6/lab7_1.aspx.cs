using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab6
{
    public partial class lab7_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
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