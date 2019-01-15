using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_01_2019_ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var Item = new Item();
            Item.Name = "qwertuy"; // set
            string itemName = Item.Name; //get
            Console.WriteLine(Item.Name); // get
            var anotherNumber = new Item
            {
                Id = 1,
                Name = "socks",
                price = 100,
            };

            //anotherNumber.DateChange = new DateTime[2];
            anotherNumber[0] = DateTime.Now;   //обращаться к объекту как к массиву

            int[] numbers = { 1, 2, 3, 4 };
            numbers[0] = 12;
            Array.Resize(ref numbers ,30);
        }
    }
}
