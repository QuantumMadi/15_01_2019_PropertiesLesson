using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_2019_Pract_work
{
    class RangeOfArray
    {
        public int HighestIndex { get; set; }
        public int LowestIndex
        {
            get
            {
                return LowestIndex;
            }
            set
            {
                if (LowestIndex < HighestIndex) LowestIndex = value;
            }
        }
    }
}
