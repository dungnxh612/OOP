using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DAO
{
    class ProductDao : BaseDao
    {
        public Product findById(int id)
        {
            var data = Database.getInstants();
            foreach (Product prod in data.selectTable(Database.PRODUCT))
            {
                if (prod.getId() == id)
                {
                    return prod;
                }
            }
            return null;
        }

        public Product findByName(string name)
        {
            var data = Database.getInstants();
            foreach (Product prod in data.selectTable(Database.PRODUCT))
            {
                if (prod.getName().Equals(name))
                {
                    return prod;
                }
            }
            return null;
        }

        public Product search(int row)
        {
            var data = Database.getInstants();
            return (Product)Convert.ChangeType(data.selectTable(Database.PRODUCT)[row], typeof(Product));
        }
    }
}
