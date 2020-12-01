using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.DEMO
{
    class ProductDemo
    {
        public void createProductTest(int id, string name, int categoryId)
        {
            var data = Database.getInstants();
            Product prod = new Product(id, name, categoryId);
            data.insertTable<Product>("productTable", prod);
        }

        public void printProduct(Product pro)
        {
            Console.WriteLine("id: " + pro.getId());
            Console.WriteLine("name: " + pro.getName());
            Console.WriteLine("categoryId: " + pro.getCategory());
        }
    }
}
