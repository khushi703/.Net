using System.Linq;
using System.Text;
using System.Web.Mvc;
using lab9_q3_mvc.Models;

namespace lab9_q3_mvc.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.AllOrders = "";
            return View();
        }

        [HttpPost]
        public ActionResult RetrieveOrders()
        {
            var orders = OrderStore.GetAll();
            StringBuilder sb = new StringBuilder();

            if (!orders.Any())
            {
                sb.AppendLine("No orders placed yet.");
            }
            else
            {
                foreach (var order in orders)
                {
                    sb.AppendLine($"Order #{order.Id} | User: {order.Username} | Date: {order.OrderDate}");
                    sb.AppendLine($"Items: {order.ItemsDisplay}");
                    sb.AppendLine(new string('-', 40));
                }
            }

            ViewBag.AllOrders = sb.ToString();
            return View("Index");
        }
    }
}
