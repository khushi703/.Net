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
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
                Response.Redirect("Login.aspx");

            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            string cs = ConfigurationManager.ConnectionStrings["UserDBConnection"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT FullName FROM Users WHERE Username=@u";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@u", Session["Username"].ToString());
                con.Open();
                object result = cmd.ExecuteScalar();
                lblUser.Text = result != null ? result.ToString() : Session["Username"].ToString();
            }
        }
    }
}