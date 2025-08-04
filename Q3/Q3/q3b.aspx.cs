using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class q3b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            FileUpload[] uploads = { file1, file2, file3 };
            int pdfCount = 0, jpgCount = 0;
            bool valid = true;

            foreach (var upload in uploads)
            {
                if (!upload.HasFile) continue;

                string ext = Path.GetExtension(upload.FileName).ToLower();
                int size = upload.PostedFile.ContentLength;

                if (ext == ".pdf")
                {
                    pdfCount++;
                    if (size > 20480) valid = false;
                }
                else if (ext == ".jpg" || ext == ".jpeg")
                {
                    jpgCount++;
                    if (size > 51200) valid = false;
                }
                else
                {
                    valid = false;
                }
            }

            if ((pdfCount + jpgCount) > 3)
            {
                lblStatus.Text = "Only 3 files allowed.";
            }
            else if (valid)
            {
                lblStatus.Text = "Files uploaded successfully.";
                // Save files if needed using upload.SaveAs()
            }
            else
            {
                lblStatus.Text = "Invalid file(s) format or size.";
            }
        }

    }
}