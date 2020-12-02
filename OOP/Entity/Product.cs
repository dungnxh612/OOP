using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Product : BaseRow,IEntity
    {
        private int category;

        public Product(int num, string str, int category)
        {
            id = num;
            name = str;
            this.category = category;
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
