using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class q3or_a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void imgMap_Click(object sender, ImageMapEventArgs e)
        {
            string shapeClicked = e.PostBackValue;
            lblShape.Text = $"You clicked on: {shapeClicked}";
        }
    }
}