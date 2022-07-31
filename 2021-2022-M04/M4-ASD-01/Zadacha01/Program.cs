using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();

            list.Add(42); // count = 1;  capacity = 2
            list.Add(13); // count = 2;  capacity = 2
            list.Add(17); // count = 3;  capacity = 4

            Console.WriteLine(list.RemoveAt(2)); // count = 2;  capacity = 2
            Console.WriteLine(list.RemoveAt(1)); // count = 1;  capacity = 2
            Console.WriteLine(list.RemoveAt(0)); // count = 0;  capacity = 2

            //list.Add(5);
            //list[0] = list[0] + 1;
            //int element = list.RemoveAt(0);
            //Console.WriteLine(element);
        }
    }
}
