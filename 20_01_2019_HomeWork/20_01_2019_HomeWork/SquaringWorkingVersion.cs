using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2019_HomeWork
{
    public class SquaringFirstVer
    {
        public int[]array { get; set; }
        private int arraySize;
        public SquaringFirstVer()
        {
            arraySize = 10;
            array = new int[arraySize];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value * value;
            }
        }
    }
}
