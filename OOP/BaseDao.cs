using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class BaseDao
    {
        protected string name;
        Database data = Database.getInstants();
        public int insert<T>(T row)
        {
            return data.insertTable<T>(name, row);
        }
        public int update<T>(T row)
        {
            return data.updateTable<T>(name, row);
        }
        public Boolean delete<T>(T row)
        {
            return data.deleteTable<T>(name, row);
        }
        public ArrayList findAll()
        {
            return data.selectTable(name);
        }
    }
}
