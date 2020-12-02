using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public abstract class BaseRow
    {
        protected string name;
        protected int id;

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
    }
}
