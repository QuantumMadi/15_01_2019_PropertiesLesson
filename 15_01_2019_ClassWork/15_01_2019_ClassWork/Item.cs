using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_2019_ClassWork
{
    public class Item
    {
        public int Id { get; set; }
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double price { get; set; }
        public DateTime CreationDate { get; private set; }
        //public DateTime[] DateChange { get; set; }
        private DateTime[] DateChange;

        public DateTime this [int index]
        {
            get
            {
                return DateChange[index];
            }
            set
            {
                DateChange[index] = value;
            }
        }

        public Item()
        {
            CreationDate = DateTime.Now;       
        }

        //private int _id;
        //private string _name;
        //private double _price;

        //public int GetId()
        //{
        //    return _id;
        //}
        //public void SetId(int id)
        //{
        //    _id = id;
        //}


    }
}
