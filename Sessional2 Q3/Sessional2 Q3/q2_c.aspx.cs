using System;
using System.Configuration;
using System.Linq;

namespace Sessional2_Q3
{
    public partial class q2_c : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["ProductDbConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            using (ProductDataDataContext db = new ProductDataDataContext(conn))
            {
                GridViewProducts.DataSource = db.Products.ToList();
                GridViewProducts.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProductDataDataContext db = new ProductDataDataContext(conn))
                {
                    Product newProduct = new Product
                    {
                        P_Name = txtName.Text.Trim(),
                        P_Cost = Convert.ToDecimal(txtCost.Text.Trim())
                    };
                    db.Products.InsertOnSubmit(newProduct);
                    db.SubmitChanges();
                }

                lblMsg.Text = "Product inserted successfully.";
                ClearFields();
                BindGrid();
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProductDataDataContext db = new ProductDataDataContext(conn))
                {
                    int id = Convert.ToInt32(txtId.Text.Trim());
                    Product prod = db.Products.SingleOrDefault(p => p.P_Id == id);

                    if (prod != null)
                    {
                        prod.P_Name = txtName.Text.Trim();
                        prod.P_Cost = Convert.ToDecimal(txtCost.Text.Trim());
                        db.SubmitChanges();

                        lblMsg.Text = "Product updated successfully.";
                        ClearFields();
                        BindGrid();
                    }
                    else
                    {
                        lblMsg.Text = "Product ID not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProductDataDataContext db = new ProductDataDataContext(conn))
                {
                    int id = Convert.ToInt32(txtId.Text.Trim());
                    Product prod = db.Products.SingleOrDefault(p => p.P_Id == id);

                    if (prod != null)
                    {
                        db.Products.DeleteOnSubmit(prod);
                        db.SubmitChanges();

                        lblMsg.Text = "Product deleted successfully.";
                        ClearFields();
                        BindGrid();
                    }
                    else
                    {
                        lblMsg.Text = "Product ID not found.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Error: " + ex.Message;
            }
        }

        private void ClearFields()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCost.Text = "";
        }
    }
}
