﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkLibrary;

namespace WorkAssistantWebApp.Controllers
{
    public class ProductManagerController : Controller
    {
        private static IWorkRepository _workHistory;

        public ProductManagerController()
        {
            if (_workHistory == null)
            {
                _workHistory = new WorkRepoDb();
            }
        }
        // GET: ProductManager
        public ActionResult Index()
        {
            return View(_workHistory.GetProductAll());
        }

        // GET: ProductManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_workHistory.GetProductById(id));
        }

        // GET: ProductManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductManager/Create
        [HttpPost]
        public ActionResult Create(Product newProduct, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                _workHistory.AddProduct(newProduct);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_workHistory.GetProductById(id));
        }

        // POST: ProductManager/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _workHistory.EditProduct(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductManager/Delete/5
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