using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());

            double time = s + m * 60.0 + h * 3600.0;

            Console.WriteLine(Math.Round(meters / time, 6));
            Console.WriteLine(Math.Round((meters / 1000) / (time / 3600), 6));
            Console.WriteLine(Math.Round((meters / 1609) / (time / 3600), 6));

        }
    }
}
