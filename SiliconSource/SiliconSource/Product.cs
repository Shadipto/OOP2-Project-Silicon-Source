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
        public decimal Total
        {
            get { return Price * Quantity; }
        }


        public Product(string id, string name, string category, decimal price, int qty)
        {
            this.ProductID = id;
            this.ProductName = name;
            this.Category = category;
            this.Price = price;
            this.Quantity = qty;
        }

        public static string GetGrandTotalString(List<Product> products)
        {
            decimal grandTotal = 0;

            foreach (var product in products)
            {
                grandTotal += product.Total;
            }

            return grandTotal.ToString();
        }


    }
}
