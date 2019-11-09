using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Storage.Interfaces;
using App.Storage.Models;
using Microsoft.AspNetCore;
using App.Configuration;

namespace App.Storage.Repositories
{
    public class InMemoryProductRepository : IProductRepository, ITransientDependency
    {
        public List<Product> products = new List<Product>();

        public InMemoryProductRepository()
        {
            AddProduct(10000, 100, "Apple");
            AddProduct(1337, 80, "Cup");
            AddProduct(5000, 19, "Pineapple");
            AddProduct(33000, 10, "Iphone");

        }
        public void AddProduct(double cost, int amount, string Type)
        {
            products.Add(new Product(amount, Type, cost));
        }

        public Product Get(int id)
        {
           return products.ElementAt(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
