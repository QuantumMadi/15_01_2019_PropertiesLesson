using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_2019_HomeWork
{
    class Index
    {
        static void Main(string[] args)
        {
            Squaring arr = new Squaring();
            arr[3] = 5;
            Console.WriteLine(arr[3]);
            //SquaringFirstVer arr = new SquaringFirstVer();
            //arr[3] = 20;
            //Console.WriteLine(arr[3]);
            Console.ReadLine();
            
        }
    }
}
