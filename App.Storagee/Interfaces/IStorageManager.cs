using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Storage.Models;

namespace App.Storage.Interfaces
{
    public interface IStorageManager
    {
        string GetProductCostById(int id);
        void AddProduct(double cost, int amount, string Type);
        void EditProduct(int id,double cost, int amount);
        IEnumerable<string> GetProducts();
        Product Get(int id);
    }
}
