using System;
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
        public ActionResult Index(string productCategory)
        {
            ViewBag.CategoryText = productCategory;
            return View(_workHistory.GetProductByCategory(productCategory));
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
                return RedirectToAction("Index", new { productCategory = "all" });
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
        public ActionResult Edit(Product updatedProduct, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                _workHistory.EditProduct(updatedProduct);
                return RedirectToAction("Index", new { productCategory = "all" });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_workHistory.GetProductById(id));
        }

        // POST: ProductManager/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                _workHistory.DeleteProduct(id);
                return RedirectToAction("Index", new { productCategory = "all" });
            }
            catch
            {
                return View();
            }
        }
    }
}
