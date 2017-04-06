using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkLibrary
{
    public class WorkRepository : IWorkRepository
    {
        public static List<WorkDay> _workList = new List<WorkDay>();
        public static List<Product> _productList = new List<Product>();

        public static int _workDayIdCounter = 0;

        public WorkRepository()
        {
            if (_workList.Count == 0)
            {
                AddSampleDays();
            }

            if (_productList.Count == 0)
            {
                AddSampleProducts();
            }
        }

        public void AddDay(WorkDay newDay)
        {
            newDay.WorkDayId = _workDayIdCounter++;
            _workList.Add(newDay);
        }

        public List<WorkDay> GetWorkHistory()
        {
            return _workList;
        }

        public WorkDay GetWorkDay(int id)
        {
            return _workList.Find(day => day.WorkDayId == id);
        }

        public void DeleteWorkDay(int id)
        {
            _workList.Remove(GetWorkDay(id));
        }


        public void EditWorkDay(WorkDay dayEdit)
        {
            _workList[_workList.IndexOf(GetWorkDay(dayEdit.WorkDayId))] = dayEdit;
        }

        public void AddSampleDays()
        {
            WorkDay day1 = new WorkDay
            {
                Start = "9:30 PM",
                End = "10:45 PM",
                Day = "Friday",
                Active = true,
                WorkLoad = new List<StockTask>
                {
                   new StockTask {Size="1.5 Lb", Quantity = 85 },
                   new StockTask {Size= "1/2 Lb", Quantity = 14}
                }
            };
            AddDay(day1);

            WorkDay day2 = new WorkDay
            {
                Start = "9:30 PM",
                End = "10:45 PM",
                Day = "Saturday",
                Active = true,
                WorkLoad = new List<StockTask>
                {
                   new StockTask {Size="1/2 Lb", Quantity = 20},
                   new StockTask {Size="4 Lb", Quantity = 10},
                }
            };
            AddDay(day2);
        }

        // Below this is your PRODUCT managment

        public static int _productIdCounter = 0;

        public void AddProduct(Product newProduct)
        {
            newProduct.ProductId = _productIdCounter++;
            _productList.Add(newProduct);
        }

        public List<Product> GetProductAll()
        {
            throw new NotImplementedException();
        }

        public void EditProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            return _productList.Find(product => product.ProductId == id);
        }

        public Product GetProductByName(string productName)
        {
            return _productList.Find(product => product.Name == productName);
        }

        public void AddSampleProducts()
        {
            Product newProduct1 = new Product()
            {
                Name = "Citric Acid",
                OurLot = "449IN" + DateTime.Now.Month,
                MlnCurrent = "5701213"
            };

            AddProduct(newProduct1);

            Product newProduct2 = new Product()
            {
                Name = "Beet Root Powder",
                OurLot = "440IN" + DateTime.Now.Month,
                MlnCurrent = "1117160650"
            };
            AddProduct(newProduct2);

            Product newProduct3 = new Product()
            {
                Name = "Dimethicone 1000",
                OurLot = "439IN" + DateTime.Now.Month,
                MlnCurrent = "J10921C22005"
            };
            AddProduct(newProduct3);

        }

        public StockTask GetStockTask(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateStockTask(StockTask newItem)
        {
            throw new NotImplementedException();
        }

        public void UpdateStockTask(StockTask updatedTask)
        {
            throw new NotImplementedException();
        }

        public void DeleteStockTask(int id)
        {
            throw new NotImplementedException();
        }


    }
}
