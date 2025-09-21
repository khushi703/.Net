using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab10.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Rectangle/Area?length=5&width=10
        public ActionResult Area(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                // Return error message
                return Content("Length and width must be greater than 0.");
            }

            double area = length * width;

            // Return JSON response
            return Json(new { Length = length, Width = width, Area = area }, JsonRequestBehavior.AllowGet);
        }
    }
}