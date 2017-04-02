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
            WorkDay newday = new WorkDay
            {
                WorkLoad = new List<StockItem>
                {
                    new StockItem
                    {
                        Start = DateTime.Now.Date.ToShortTimeString()
                    }
                }
            };

            AddDay(newday);
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
            throw new NotImplementedException();
        }

        public void DeleteWorkDay(int id)
        {
            throw new NotImplementedException();
        }

        public void EditWorkDay(WorkDay dayEdit)
        {
            throw new NotImplementedException();
        }

        public List<string> GetProductAll()
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string productName)
        {
            throw new NotImplementedException();
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
    }
}
