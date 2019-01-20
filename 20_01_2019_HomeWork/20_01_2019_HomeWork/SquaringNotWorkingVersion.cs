using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2019_HomeWork
{
    public interface intContainer
    {
        int this[int index] { get; set; }
    }
   public class Squaring 
    {
        private List<int> someArray;
        private  int size;
        public Squaring ()
        {
            size = 10;
            someArray = new List<int>(size);
        }
        public Squaring(int size)
        {
            this.size = size; 
            someArray = new List<int>(this.size);
        }
        public int this[int index]
        {
           get
            {
                return someArray[index];
            }
            set
            {
                someArray.Insert(index, value);
            }
        }
      
       
    }
}
