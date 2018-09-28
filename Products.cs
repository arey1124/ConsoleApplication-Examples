using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        private List<Products> products;

        public List<Products> GetProducts()
        {
            products = new List<Products>()
                {
                    new Products { id = 1, name = "A", price = 10, quantity = 15 },
                    new Products{ id = 2, name = "B", price = 20, quantity = 25 }
                };
            return products;
        }

        public void AddProduct(Products p)
        {
            this.products.Add(p);
        }

        public void FindProduct(int id)
        {
            int index = products.FindIndex(products => products.id == id);
            if(index == -1)
            {
                Console.WriteLine("Product not found..");
            }
            else
            {
                Console.WriteLine("The product is found at {0}", index);
            }
        }
    }
}
