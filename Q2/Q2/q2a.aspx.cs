using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class q2a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            int count;
            if (int.TryParse(txtCount.Text, out count))
            {
                phControls.Controls.Clear();
                string selected = ddlType.SelectedValue;

                for (int i = 0; i < count; i++)
                {
                    if (selected == "Hyperlink")
                    {
                        HyperLink hl = new HyperLink();
                        hl.Text = $"Hyperlink {i + 1}";
                        hl.NavigateUrl = "https://example.com";
                        phControls.Controls.Add(hl);
                    }
                    else if (selected == "LinkButton")
                    {
                        LinkButton lb = new LinkButton();
                        lb.Text = $"LinkButton {i + 1}";
                        phControls.Controls.Add(lb);
                    }
                    else if (selected == "ImageButton")
                    {
                        ImageButton ib = new ImageButton();
                        ib.ImageUrl = "~/images/sample.png";
                        phControls.Controls.Add(ib);
                    }

                    phControls.Controls.Add(new Literal { Text = "<br/>" });
                }
            }
        }

    }
}