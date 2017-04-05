using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkLibrary;

namespace WorkAssistantWebApp.Controllers
{
    public class DayWorkLoadController : Controller
    {
        private static IWorkRepository _workHistory;

        public DayWorkLoadController()
        {
            if (_workHistory == null)
            {
                _workHistory = new WorkRepoDb();
            }
        }
        // GET: DayWorkLoad
        public ActionResult Index(int id)
        {
            return View(_workHistory.GetWorkDay(id));
        }

        // GET: DayWorkLoad/Details/5
        public ActionResult Details(int id)
        {
            return View(_workHistory.GetStockTask(id));
        }

        // GET: DayWorkLoad/Create
        public ActionResult Create(int id)
        {
            ViewBag.workdayid = id;
            return View();
        }

        // POST: DayWorkLoad/Create
        [HttpPost]
        public ActionResult Create(StockTask newItem, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _workHistory.CreateStockTask(newItem);
                return RedirectToAction("Index", new { id = newItem.WorkDayId });
            }
            catch
            {
                return View();
            }
        }

        // GET: DayWorkLoad/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_workHistory.GetStockTask(id));
        }

        // POST: DayWorkLoad/Edit/5
        [HttpPost]
        public ActionResult Edit(StockTask updatedTask, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _workHistory.UpdateStockTask(updatedTask);
                return RedirectToAction("Index", new { id = updatedTask.WorkDayId });
            }
            catch
            {
                return View();
            }
        }

        // GET: DayWorkLoad/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_workHistory.GetStockTask(id));
        }

        // POST: DayWorkLoad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                StockTask task = _workHistory.GetStockTask(id);
                _workHistory.DeleteStockTask(id);
                return RedirectToAction("Index" ,new { id = task.WorkDayId});
            }
            catch
            {
                return View();
            }
        }
    }
}
