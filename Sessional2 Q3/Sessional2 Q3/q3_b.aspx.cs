using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q3_b : System.Web.UI.Page
    {
        private DataClasses1DataContext db;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connString = ConfigurationManager.ConnectionStrings["Q3bDbConnectionString"].ConnectionString;
                db = new DataClasses1DataContext(connString);
                // Join books and categories for grid
                var bookDetails = from b in db.Books
                                  join c in db.Categories on b.B_Cat equals c.C_Id
                                  select new
                                  {
                                      b.B_Id,
                                      b.B_Title,
                                      b.B_Author,
                                      c.C_Name
                                  };
                GridViewBooks.DataSource = bookDetails.ToList();
                GridViewBooks.DataBind();

                // i. Total number of literature books
                int literatureId = db.Categories.First(c => c.C_Name == "Literature").C_Id;
                int literatureCount = db.Books.Count(b => b.B_Cat == literatureId);
                LabelLiteratureCount.Text = $"Total Literature Books: {literatureCount}";

                // ii. All details of Pro ASP.NET Core book including category
                var proAsp = (from b in db.Books
                              join c in db.Categories on b.B_Cat equals c.C_Id
                              where b.B_Title == "Pro ASP.NET Core"
                              select new
                              {
                                  b.B_Id,
                                  b.B_Title,
                                  b.B_Author,
                                  c.C_Name
                              }).FirstOrDefault();
                if (proAsp != null)
                    LabelProASPDetails.Text = $"Pro ASP.NET Core: ID={proAsp.B_Id}, Author={proAsp.B_Author}, Category={proAsp.C_Name}";

                // iii. Author of Tatvamasi Book
                var tatvamasi = db.Books.FirstOrDefault(b => b.B_Title == "Tatvamasi");
                if (tatvamasi != null)
                    LabelTatvamasiAuthor.Text = $"Tatvamasi Author: {tatvamasi.B_Author}";

                // iv. Category of books Morgan Housel is writing
                var houselBookCat = (from b in db.Books
                                     join c in db.Categories on b.B_Cat equals c.C_Id
                                     where b.B_Author == "Morgan Housel"
                                     select c.C_Name).FirstOrDefault();
                LabelHouselCategory.Text = $"Morgan Housel book category: {houselBookCat}";
            }
        }
    }
}