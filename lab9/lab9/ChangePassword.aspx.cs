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
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string newPass = txtNewPassword.Text.Trim();

            string cs = ConfigurationManager.ConnectionStrings["UserDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "UPDATE Users SET Password=@p WHERE Username=@u";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@p", newPass);
                cmd.Parameters.AddWithValue("@u", Session["Username"].ToString());

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                lblStatus.Text = rows > 0 ? "Password changed successfully!" : "Error updating password.";
            }
        }
    }
}