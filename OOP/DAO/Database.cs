using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Database
    {
        private static Database _instance;
        private ArrayList productTable = new ArrayList();
        private ArrayList categoryTable = new ArrayList();
        private ArrayList accessoryTable = new ArrayList();
        public const string PRODUCT = "productTable";
        public const string CATEGORY = "categoryTable";
        public const string ACCESS = "accessoryTable";


        public static Database getInstants()
        {
            if(_instance == null)
            {
                _instance = new Database();
            }
            return _instance;
        }
        public int insertTable<T>(string name, T row)
        {
            if (name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                productTable.Add(product);               
                return 1;
            }
            if (name.Equals(CATEGORY))
            {
                Category cate = (Category)Convert.ChangeType(row, typeof(Category));
                categoryTable.Add(cate);
                return 1;
            }
            if (name.Equals(ACCESS))
            {
                Accessory acc = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                accessoryTable.Add(acc);
                return 1;
            }

            return 0;
        }

        public ArrayList selectTable(string name)
        {
            if (name.Equals(PRODUCT))
            {
                return productTable;
            }
            if (name.Equals(CATEGORY))
            {
                return productTable;
            }
            if (name.Equals(ACCESS))
            {
                return productTable;
            }
            return null;
        }

        public int updateTable<T>(string name, T row)
        {
            if (name.Equals(PRODUCT))
            {
                Product product = (Product)Convert.ChangeType(row, typeof(Product));
                for(int i = 0; i < productTable.Count; i++)
                {
                    Product proTmp = (Product)Convert.ChangeType(productTable[i], typeof(Product));
                    if (product.getId() == proTmp.getId())
                    {
                        productTable[i] = proTmp;
                        return 1;
                    }
                }

            }
            if (name.Equals(CATEGORY))
            {
                Category category = (Category)Convert.ChangeType(row, typeof(Category));
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    Category cateTmp = (Category)Convert.ChangeType(categoryTable[i], typeof(Category));
                    if (category.getId() == cateTmp.getId())
                    {
                        categoryTable[i] = cateTmp;
                        return 1;
                    }
                }

            }
            if (name.Equals(ACCESS))
            {
                Accessory accessory = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    Accessory accTmp = (Accessory)Convert.ChangeType(accessoryTable[i], typeof(Accessory));
                    if (accessory.getId() == accTmp.getId())
                    {
                        accessoryTable[i] = accTmp;
                        return 1;
                    }
                }
            }
            return 0;
        }

        public bool deleteTable<T>(string name, T row)
        {
            
            if (name.Equals(PRODUCT))
            {
                productTable.Remove(row);
                return true;
            }
            if (name.Equals(CATEGORY))
            {
                categoryTable.Remove(row);
                return true;
            }
            if (name.Equals(ACCESS))
            {
                accessoryTable.Remove(row);
                return true;
            }
            return false;
        }

        public void truncateTable(string name)
        {
            if (name.Equals(PRODUCT))
            {
                productTable.Clear();
            }
            if (name.Equals(CATEGORY))
            {
                productTable.Clear();
            }
            if (name.Equals(ACCESS))
            {
                productTable.Clear();
            }
        }
        public int updateTable<T>(string name, T row, int id)
        {
            if (name.Equals(PRODUCT))
            {
                for(int i =0; i<productTable.Count; i++)
                {
                    Product product = (Product)Convert.ChangeType(row, typeof(Product));
                    if (product.getId() == id)
                    {
                        productTable[i] = row;
                        return 1;
                    }
                }
            }
            if (name.Equals(CATEGORY))
            {
                for (int i = 0; i < categoryTable.Count; i++)
                {
                    Category cate = (Category)Convert.ChangeType(row, typeof(Category));
                    if (cate.getId() == id)
                    {
                        categoryTable[i] = row;
                        return 1;
                    }
                }
            }
            if (name.Equals(ACCESS))
            {
                for (int i = 0; i < accessoryTable.Count; i++)
                {
                    Accessory acc = (Accessory)Convert.ChangeType(row, typeof(Accessory));
                    if (acc.getId() == id)
                    {
                        accessoryTable[i] = row;
                        return 1;
                    }
                }
            }
            return 0;
        }

    }
}
