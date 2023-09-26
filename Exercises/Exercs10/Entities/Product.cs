using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs10.Entities
{
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product() { }

        public Product(string name, double price)
        {
            ProductName = name;
            ProductPrice = price;
        }
    }
}