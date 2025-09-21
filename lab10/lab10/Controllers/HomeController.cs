using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab10.Controllers
{
    public class HomeController : Controller
    {
        // Cache this action output for 10 seconds
        [OutputCache(Duration = 10, VaryByParam = "none")]
        public ActionResult Index()
        {
            ViewBag.ServerTime = DateTime.Now.ToString("HH:mm:ss");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}