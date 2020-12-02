using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    interface IDao
    {
        public int insert<T>(T row);
        public int update<T>(T row);
        public Boolean delete<T>(T row);
        public ArrayList findAll();
    }
}
