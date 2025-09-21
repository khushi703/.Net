using lab10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab10.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        // GET: /Calculator
        public ActionResult Index()
        {
            // Explicitly tell MVC to use Calculator.cshtml view
            return View("Calculator");
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "Add":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Subtract":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Multiply":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Divide":
                    if (model.Number2 != 0)
                        model.Result = model.Number1 / model.Number2;
                    else
                        ModelState.AddModelError("", "Cannot divide by zero!");
                    break;
                default:
                    ModelState.AddModelError("", "Invalid Operation!");
                    break;
            }

            // Return the same Calculator.cshtml view
            return View("Calculator", model);
        }
    }
}