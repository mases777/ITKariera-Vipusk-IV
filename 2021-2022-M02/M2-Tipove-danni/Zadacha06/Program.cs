using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int water = 0;
            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                water += liters;
                if (water > 255)
                {
                    water -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(water);
        }
    }
}
