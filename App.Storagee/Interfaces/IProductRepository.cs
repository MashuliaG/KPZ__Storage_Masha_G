using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Storage.Models;

namespace App.Storage.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(double cost, int amount, string Type);
        IEnumerable<Product> GetProducts();
        Product Get(int id);
    }
}
