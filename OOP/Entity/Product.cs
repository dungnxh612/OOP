using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product
    {
        private int id;
        private string name;
        private int category;

        public Product(int id, string name, int category)
        {
            this.id = id;
            this.name = name;
            this.category = category;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public int getCategory()
        {
            return category;
        }

        public void setCategory(int category)
        {
            this.category = category;
        }
    }
}
