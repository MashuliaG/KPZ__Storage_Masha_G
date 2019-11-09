using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Storage.Models
{
    public class Product
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public double Cost { get; set; }

        public Product(int amoun,string type,double cost)
        {
            this.Amount = amoun;
            this.Type = type;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return $"Type: {Type} Amount:{Amount}, Cost per one: {Cost} $ ";
        }
    }
}
