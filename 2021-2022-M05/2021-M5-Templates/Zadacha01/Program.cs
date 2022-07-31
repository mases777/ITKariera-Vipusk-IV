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
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

            Box<string> box2 = new Box<string>();
            box2.Add("Hello");
            box2.Add("Hello 2");
            box2.Add("Hello 3");
            Console.WriteLine(box2.Remove());
            box2.Add("Hello 4");
            box2.Add("Hello 5");
            Console.WriteLine(box2.Remove());

        }
    }
}
