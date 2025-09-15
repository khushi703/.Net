using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q2_b : System.Web.UI.Page
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