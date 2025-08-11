using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab4
{
    public partial class ex4_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string ext = Path.GetExtension(FileUpload1.FileName).ToLower();
                int size = FileUpload1.PostedFile.ContentLength;

                if ((ext == ".pdf" || ext == ".docx") && size < 10240) // 10KB
                {
                    string path = Server.MapPath("~/Uploads/");
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    FileUpload1.SaveAs(path + FileUpload1.FileName);
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "File uploaded successfully.";
                }
                else
                {
                    lblMessage.Text = "Only PDF/DOCX under 10KB allowed.";
                }
            }
            else
            {
                lblMessage.Text = "Please choose a file.";
            }
        }
    }
}