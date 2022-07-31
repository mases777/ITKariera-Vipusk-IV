using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = 2 * (a + b);
            double s = a * b;
            decimal d = (decimal)Math.Sqrt(Math.Pow(a, 2) + b * b);

            Console.WriteLine($"p = {p}");
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"d = {d}");
        }
    }
}
