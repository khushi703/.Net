using lab11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab11.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbContext db = new StudentDbContext();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            var student = db.Students.FirstOrDefault(s => s.StudentId == id);
            if (student != null)
                return View("StudentDetails", student);
            else
            {
                ViewBag.Message = "Student not found!";
                return View();
            }
        }
    }
}