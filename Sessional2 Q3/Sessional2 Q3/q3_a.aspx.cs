using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q3_a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            string raw = txtISBN.Text.Trim();
            string isbn = NormalizeIsbn(raw);

            if (!IsValidIsbn(isbn))
            {
                lblMessage.Text = "Invalid ISBN format. Enter a valid ISBN.";
                gvResults.DataSource = null;
                gvResults.DataBind();
                return;
            }

            string connStr = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT B_ISBN, B_Name, B_Author, B_Price FROM dbo.[Table] WHERE B_ISBN = @isbn", conn))
            {
                cmd.Parameters.Add(new SqlParameter("@isbn", SqlDbType.VarChar, 20) { Value = isbn });

                conn.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    gvResults.DataSource = rdr;
                    gvResults.DataBind();
                    if (!rdr.HasRows)
                    {
                        lblMessage.Text = "No book found for that ISBN.";
                    }
                }
            }
        }

        private string NormalizeIsbn(string s)
        {
            if (string.IsNullOrEmpty(s)) return string.Empty;
            return s.Replace("-", "").Replace(" ", "").ToUpperInvariant();
        }

        private bool IsValidIsbn(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return Regex.IsMatch(s, @"^\d{13}$") || Regex.IsMatch(s, @"^\d{9}[\dX]$");
        }
    }
}