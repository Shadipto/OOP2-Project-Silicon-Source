using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiliconSource
{
    internal class Product
    {
        public string ProductID { get; set; }           
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }
        public decimal Total
        {
            get { return Price * Quantity; }
        }


        public Product(string id, string name, string category, decimal price, int qty, int stock)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = qty;
            this.Stock = stock;
        }

    }
}
