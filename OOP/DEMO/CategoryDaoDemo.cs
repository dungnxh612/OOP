using OOP.DAO;
using OOP.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP.DEMO
{
    class CategoryDaoDemo
    {
        private CategoryDAO cateD = new CategoryDAO();
        public void insertTest(int raw)
        {
            cateD.insert(raw);
        }
        public void updateTest(int raw)
        {
            cateD.update(raw);
        }
        public void deleteTest(int raw)
        {
            cateD.insert(raw);
        }
        public void findAllTest()
        {
            ArrayList cateList =  cateD.findAll();
            foreach(ArrayList arr in cateList)
            {
                Console.WriteLine(arr);
            }
        }
        public void findByIdTest(int id)
        {
            Category tmp = cateD.findById(id);
            Console.WriteLine("id: " + tmp.getId());
            Console.WriteLine("name: " + tmp.getName());
        }

    }
}
