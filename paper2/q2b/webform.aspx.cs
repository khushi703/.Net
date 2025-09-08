using System;
using paper.DAL;  // reference DAL namespace

namespace paper
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ProductDAL dal = new ProductDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            decimal cost = Convert.ToDecimal(txtCost.Text);

            dal.InsertProduct(name, cost);
            BindGrid();

            txtName.Text = "";
            txtCost.Text = "";
        }

        private void BindGrid()
        {
            GridView1.DataSource = dal.GetAllProducts();
            GridView1.DataBind();
        }
    }
}
