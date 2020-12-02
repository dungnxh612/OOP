using OOP.DEMO;
using System;
using System.Collections;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseDemo dataDemo = new DatabaseDemo();
            Database data = new Database();
            /*            dataDemo.initDatabase();
                        dataDemo.printTableTest("productTable");
                        Console.WriteLine("---------------------------------------------------");
                        var arrL = dataDemo.selectTableTest("productTable");
                        for (int i = 0; i < arrL.Count; i++)
                        {
                            Product product = (Product)Convert.ChangeType(arrL[i], typeof(Product));
                            Console.WriteLine("id: " + product.getId());
                            Console.WriteLine("name: " + product.getName());
                            Console.WriteLine("categoryId: " + product.getCategory());
                        }*/
            ProductDemo proDemo = new ProductDemo();
            proDemo.createProductTest(2, "data", 3);
            dataDemo.printTableTest(Database.PRODUCT);
        }
    }
}
