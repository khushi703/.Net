using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            List<string> items = new List<string>
            {
                "Apple",
                "Banana",
                "Orange",
                "Mango",
                "Grapes"
            };

            // Pass list using ViewBag
            ViewBag.FruitList = items;

            // Pass list using ViewData
            ViewData["FruitListData"] = items;

            return View();
        }
    }
}