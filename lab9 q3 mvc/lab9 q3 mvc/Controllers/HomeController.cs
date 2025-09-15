using lab9_q3_mvc.Models;
using System.Linq;
using System.Web.Mvc;

namespace lab9_q3_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PlaceOrder(string[] selectedItems)
        {
            if (selectedItems != null && selectedItems.Length > 0)
            {
                Order order = new Order
                {
                    Username = "Guest", // Or get username from logged-in user if you have auth
                    Items = selectedItems.ToList()
                };

                OrderStore.AddOrder(order);
                ViewBag.Message = "✅ Order placed successfully!";
            }
            else
            {
                ViewBag.Message = "⚠️ Please select at least one item before placing the order.";
            }

            return View("Index");
        }
    }
}
