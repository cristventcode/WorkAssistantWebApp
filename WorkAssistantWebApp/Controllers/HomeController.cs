using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkLibrary;

namespace WorkAssistantWebApp.Controllers
{
    public class HomeController : Controller
    {
        public static WorkRepository _workHistory = new WorkRepository();

        public ActionResult Index()
        {
            return View(_workHistory.GetWorkHistory());
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