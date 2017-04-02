﻿using System;
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
            return View();
        }

        // GET: DayWorkLoad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DayWorkLoad/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DayWorkLoad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DayWorkLoad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DayWorkLoad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DayWorkLoad/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
