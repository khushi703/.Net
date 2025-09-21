using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;

namespace lab10.Controllers
{
    public class CacheController : Controller
    {
        // GET: Cache
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult XmlCache()
        {
            string cacheKey = "XmlData";
            string xmlData;

            // Check if cached
            if (HttpContext.Cache[cacheKey] == null)
            {
                string filePath = Server.MapPath("~/Data.xml");

                // Read XML file
                xmlData = System.IO.File.ReadAllText(filePath);

                // Set cache with file dependency
                CacheDependency dependency = new CacheDependency(filePath);
                HttpContext.Cache.Insert(cacheKey, xmlData, dependency,
                    Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration);
            }
            else
            {
                xmlData = HttpContext.Cache[cacheKey].ToString();
            }

            ViewBag.XmlData = xmlData;
            ViewBag.CachedTime = DateTime.Now.ToString("HH:mm:ss");
            return View();
        }

        public ActionResult SqlCache()
        {
            string cacheKey = "SqlData";
            string sqlData;

            if (HttpContext.Cache[cacheKey] == null)
            {
                string connStr = System.Configuration.ConfigurationManager
                                   .ConnectionStrings["MessageDB"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 Message FROM Messages", conn);
                    SqlCacheDependency dependency = new SqlCacheDependency("MessageDB", "Messages");

                    conn.Open();
                    sqlData = (string)cmd.ExecuteScalar();

                    HttpContext.Cache.Insert(cacheKey, sqlData, dependency);
                }
            }
            else
            {
                sqlData = HttpContext.Cache[cacheKey].ToString();
            }

            ViewBag.SqlData = sqlData;
            ViewBag.CachedTime = DateTime.Now.ToString("HH:mm:ss");
            return View();
        }
    }
}