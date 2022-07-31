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
            var line = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            foreach (var item in line)
            {
                if (counts.ContainsKey(item)) counts[item]++;
                else counts[item] = 1;
            }

            foreach (var item in counts.Keys)
            {
                Console.WriteLine($"{item} -> {counts[item]}");
            }
        }
    }
}
