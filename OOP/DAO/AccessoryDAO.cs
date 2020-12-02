using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DAO
{
    class AccessoryDAO : BaseDao
    {      

        public Accessory findById(int id)
        {
            var data = Database.getInstants();
            foreach (Accessory acc in data.selectTable(Database.ACCESS))
            {
                if (acc.getId() == id)
                {
                    return acc;
                }
            }
            return null;
        }

        public Accessory findByName(string name)
        {
            var data = Database.getInstants();
            foreach (Accessory acc in data.selectTable(Database.ACCESS))
            {
                if (acc.getName().Equals(name))
                {
                    return acc;
                }
            }
            return null;
        }

        public Accessory search(int row)
        {
            var data = Database.getInstants();
            return (Accessory)Convert.ChangeType(data.selectTable(Database.ACCESS)[row], typeof(Accessory));
        }
    }
}
