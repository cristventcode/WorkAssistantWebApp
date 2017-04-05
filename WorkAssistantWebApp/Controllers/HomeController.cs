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
        private static IWorkRepository _workHistory;
        public HomeController()
        {
            if (_workHistory == null)
            {
                _workHistory = new WorkRepoDb();
            }
        }
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