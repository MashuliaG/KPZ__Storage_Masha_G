using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Storage.Interfaces;
using App.Configuration;
using App.Storage.Models;
using App.Storage.Repositories;

namespace App.Storage.Services
{
    public class StorageManager : IStorageManager, ITransientDependency
    {
        IProductRepository repository;
        public StorageManager(IProductRepository _repo )
        {
            repository = _repo;
        }
        public void AddProduct(double cost, int amount, string Type)
        {
            repository.AddProduct(cost, amount, Type);
        }

        public void EditProduct(int id,double cost, int amount)
        {
            var res = repository.Get(id);
            res.Amount += amount;
            res.Cost = cost;
        }

        public Product Get(int id)
        {
            return repository.Get(id);
        }

        public string GetProductCostById(int id)
        {
            return $"Cost: {repository.Get(id).Cost}";
        }

        public IEnumerable<string> GetProducts()
        {
            var list = new List<string>();
            repository.GetProducts().ToList().ForEach(f => list.Add(f.ToString()));
            return list;
        }


    }
}
