using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha07
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            // 1 2 3 4 5 6                  2, 4, 6
            // 11 13 18 95 2 112 81 46      18, 2, 112, 46
            Queue<int> queue = new Queue<int>(line);
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < line.Length; i++)
            {
                int even = queue.Dequeue();
                if (even % 2 == 0) evenNumbers.Add(even);
            }
            Console.WriteLine(string.Join(", ", evenNumbers));

        }
    }
}
