using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITC_Azure_Test_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your new application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your new contact page.";

            return View();
        }
    }
}