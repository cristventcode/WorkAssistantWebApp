using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLibrary
{
    public class WorkRepoDb : IWorkRepository
    {
        public WorkRepoDb()
        {

        }
        public void AddDay(WorkDay newDay)
        {
            using (var db = new WorkDbContext())
            {
                db.WorkDayTable.Add(newDay);
                db.SaveChanges();
            }
        }

        public void AddProduct(Product newProduct)
        {
            using (var db = new WorkDbContext())
            {
                db.ProductTabel.Add(newProduct);
                db.SaveChanges();
            }
        }

        public void DeleteWorkDay(int id)
        {
            using (var db = new WorkDbContext())
            {
                var day = db.WorkDayTable.Find(id);
                db.WorkDayTable.Remove(day);
                db.SaveChanges();
            }
        }

        public void EditWorkDay(WorkDay dayEdit)
        {
            using (var db = new WorkDbContext())
            {
                db.WorkDayTable.Attach(dayEdit);
                var entry = db.Entry(dayEdit);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Product> GetProductAll()
        {
            using (var db = new WorkDbContext())
            {
                var products = from product in db.ProductTabel
                               select product;

                return products.ToList();
            }
        }

        public Product GetProductById(int id)
        {
            using (var db = new WorkDbContext())
            {
                return db.ProductTabel.Find(id);
            }
        }

        public List<Product> GetProductByName(string productName)
        {
            using (var db = new WorkDbContext())
            {
                var foundProduct = from product in db.ProductTabel
                                   where product.Name == productName
                                   select product;
                return foundProduct.ToList();
            }
        }


        public void EditProduct(Product updatedProduct)
        {
            using (var db = new WorkDbContext())
            {
                db.ProductTabel.Attach(updatedProduct);
                var entry = db.Entry(updatedProduct);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            using (var db = new WorkDbContext())
            {
                var product = db.ProductTabel.Find(id);
                db.ProductTabel.Remove(product);
                db.SaveChanges();
            }
        }

        public List<Product> GetProductByCategory(string productCategory)
        {
            if (productCategory == "All")
            {
                var allProducts = GetProductAll();
                return allProducts;
            }

            using (var db = new WorkDbContext())
            {
                var products = from product in db.ProductTabel
                               where product.Category == productCategory
                               select product;

                return products.ToList();
            }
        }

        public WorkDay GetWorkDay(int id)
        {
            using (var db = new WorkDbContext())
            {
                var workday = db.WorkDayTable.Find(id);
                db.Entry(workday).Collection(day => day.WorkLoad).Load();
                return workday;
            }
        }

        public List<WorkDay> GetWorkHistory()
        {
            using (var db = new WorkDbContext())
            {
                var days = from day in db.WorkDayTable
                           select day;

                return days.ToList();
            }
        }

        public StockTask GetStockTask(int id)
        {
            using (var db = new WorkDbContext())
            {
                return db.StockItemTable.Find(id);
            }
        }

        public void CreateStockTask(StockTask newItem)
        {
            using (var db = new WorkDbContext())
            {
                db.StockItemTable.Add(newItem);
                db.SaveChanges();
            }
        }

        public void UpdateStockTask(StockTask updatedTask)
        {
            using (var db = new WorkDbContext())
            {
                db.StockItemTable.Attach(updatedTask);
                var entry = db.Entry(updatedTask);
                entry.State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void DeleteStockTask(int id)
        {
            using (var db = new WorkDbContext())
            {
                var task = db.StockItemTable.Find(id);
                db.StockItemTable.Remove(task);
                db.SaveChanges();
            }
        }
    }
}
