using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DAO
{
    class CategoryDAO : BaseDao
    {

        public Category findById(int id)
        {
            var data = Database.getInstants();
            foreach(Category cate in data.selectTable(Database.CATEGORY))
            {
                if(cate.getId() == id)
                {
                    return cate;
                }
            }
            return null;
        }
    }
}
