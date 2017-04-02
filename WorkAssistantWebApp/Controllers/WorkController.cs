using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkLibrary;

namespace WorkAssistantWebApp.Controllers
{
    public class WorkController : Controller
    {
        private static IWorkRepository _workHistory;

        public WorkController()
        {
            if (_workHistory == null)
            {
                _workHistory = new WorkRepoDb();
            }
        }

        // GET: Work
        public ActionResult Index()
        {
            return View(_workHistory.GetWorkHistory());
        }

        // GET: Work/Details/5
        public ActionResult Details(int id)
        {
            return View(_workHistory.GetWorkDay(id));
        }

        // GET: Work/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Work/Create
        [HttpPost]
        public ActionResult Create(WorkDay newWorkDay, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _workHistory.AddDay(newWorkDay);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Work/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_workHistory.GetWorkDay(id));
        }

        // POST: Work/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, WorkDay dayEdit, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _workHistory.EditWorkDay(dayEdit);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Work/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_workHistory.GetWorkDay(id));
        }

        // POST: Work/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _workHistory.DeleteWorkDay(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
