using System.Collections.Generic;

namespace WorkLibrary
{
    public interface IWorkRepository
    {
        void AddDay(WorkDay newDay);
        void AddProduct(Product newProduct);
        void DeleteWorkDay(int id);
        void EditWordDay(WorkDay dayEdit);
        Product GetProduct(int id);
        List<string> GetProductAll();
        WorkDay GetWorkDay(int id);
        List<WorkDay> GetWorkHistory();
    }
}