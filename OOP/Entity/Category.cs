using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Entity
{
    class Category : BaseRow
    {
        public Category(int num, string str)
        {
            id = num;
            name = str;
        }

    }
}
