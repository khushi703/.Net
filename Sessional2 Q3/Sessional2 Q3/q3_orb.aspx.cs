using System;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q3_orb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Always set the connection string on every load
            SqlDataSourceBooks.ConnectionString = ConfigurationManager.ConnectionStrings["Q3bDbConnectionString"].ConnectionString;
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataSourceBooks.InsertParameters["Title"].DefaultValue = txtTitle.Text.Trim();
                SqlDataSourceBooks.InsertParameters["Author"].DefaultValue = txtAuthor.Text.Trim();
                SqlDataSourceBooks.InsertParameters["Category"].DefaultValue = txtCategory.Text.Trim();
                SqlDataSourceBooks.Insert();

                lblMsg.Text = "Book inserted successfully.";
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtCategory.Text = "";
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }

        protected void GridViewBooks_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int categoryValue = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "B_Cat"));
                if (categoryValue == 3)
                {
                    e.Row.CssClass = "highlight-cat3";
                }
            }
        }
    }
}
