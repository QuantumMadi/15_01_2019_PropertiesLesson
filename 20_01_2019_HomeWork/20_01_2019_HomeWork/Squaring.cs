using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2019_HomeWork
{
    public class Element
    {
        public int Elem { get; set; }
    }
   public class Squaring
    {
        private Element[] array;
        private int _arraySize;
        public Squaring()
        {
            _arraySize = 10;
            array = new Element[_arraySize];
        }
        public Squaring(int arraySize)
        {
            _arraySize = arraySize;
            array = new Element[_arraySize];
        }
        public Element this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                Element some ;
                array[index] = value;
            }
        }
    }
}
