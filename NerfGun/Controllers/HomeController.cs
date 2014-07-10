using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NerfGun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Data Collector";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Data Collector provides allows the collection of data with an associated location";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "mike@xsdconsulting.com";

            return View();
        }
    }
}
