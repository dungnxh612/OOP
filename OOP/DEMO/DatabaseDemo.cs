using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class DatabaseDemo
    {
        public void insertTableTest(string name, int row)
        {
            var data = Database.getInstants();
            data.insertTable(name, row);
        }

        public ArrayList selectTableTest(string name)
        {
            var data = Database.getInstants();
            return data.selectTable(name);
        }

        public void updateTableTest(string name, int row, int id)
        {
            var data = Database.getInstants();
            data.updateTable(name, row, id);
        }

        public void deleteTableTest(string name, int row)
        {
            var data = Database.getInstants();
            var index = (Product)Convert.ChangeType(data.selectTable(Database.PRODUCT)[row], typeof(Product));
            data.deleteTable<Product>(name, index);
        }

        public void truncateTableTest(string name)
        {
            var data = Database.getInstants();
            data.truncateTable(name);
        }

        public void initDatabase()
        {
            var data = Database.getInstants();
            for(int i = 0; i < 10; i++)
            {
                Product prod = new Product(i, "PRO" + i, 10 * i);
                Category cate = new Category(i, "CATE" + i);
                Accessory acc = new Accessory(i, "ACC" + i);
                data.insertTable<Product>("productTable", prod);
                data.insertTable<Category>("categoryTable", cate);
                data.insertTable<Accessory>("accessoryTable", acc);
            }
        }

        public void printTableTest(string name)
        {
            var data = Database.getInstants();
            if (name.Equals("productTable"))
            {
                for(int i = 0; i < data.selectTable(Database.PRODUCT).Count; i++)
                {
                    Product product = (Product)Convert.ChangeType(data.selectTable(Database.PRODUCT)[i], typeof(Product));
                    Console.WriteLine("id: " + product.getId());
                    Console.WriteLine("name: " + product.getName());
                    Console.WriteLine("categoryId: " + product.getCategory());
                }
            }
            if (name.Equals("categoryTable"))
            {
                for (int i = 0; i < data.selectTable(Database.CATEGORY).Count; i++)
                {
                    Category cate = (Category)Convert.ChangeType(data.selectTable(Database.CATEGORY)[i], typeof(Category));
                    Console.WriteLine("id: " + cate.getId());
                    Console.WriteLine("name: " + cate.getName());
                }
            }
            if (name.Equals("accessoryTable"))
            {
                for (int i = 0; i < data.selectTable(Database.ACCESS).Count; i++)
                {
                    Accessory acc = (Accessory)Convert.ChangeType(data.selectTable(Database.ACCESS)[i], typeof(Accessory));
                    Console.WriteLine("id: " + acc.getId());
                    Console.WriteLine("name: " + acc.getName());
                }
            }
        }
    }
}
