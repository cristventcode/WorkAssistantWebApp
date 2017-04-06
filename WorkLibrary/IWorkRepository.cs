using System.Collections.Generic;

namespace WorkLibrary
{
    public interface IWorkRepository
    {
        void AddDay(WorkDay newDay);
        void AddProduct(Product newProduct);
        void DeleteWorkDay(int id);
        void EditWorkDay(WorkDay dayEdit);
        Product GetProductById(int id);
        void EditProduct(Product updatedProduct);
        void DeleteProduct(int id);
        List<Product> GetProductByCategory(string productCategory);
        List<Product> GetProductAll();
        WorkDay GetWorkDay(int id);
        List<WorkDay> GetWorkHistory();
        StockTask GetStockTask(int id);
        void CreateStockTask(StockTask newItem);
        void UpdateStockTask(StockTask updatedTask);
        void DeleteStockTask(int id);
    }
}