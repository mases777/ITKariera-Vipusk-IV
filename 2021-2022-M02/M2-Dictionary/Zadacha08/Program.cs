using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new int[n];
            var numbers2 = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                numbers[i] = num;
                numbers2.Add(num);
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");

            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Sum = {numbers2.Sum()}");
            Console.WriteLine($"Min = {numbers2.Min()}");
            Console.WriteLine($"Max = {numbers2.Max()}");
            Console.WriteLine($"Average = {numbers2.Average()}");
        }
    }
}
