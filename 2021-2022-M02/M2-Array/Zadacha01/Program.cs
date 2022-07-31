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
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int min = arr[0], max = arr[0], sum = 0;
            double average = 0.0;
            foreach (var item in arr)
            {
                if (item < min) min = item;
                if (item > max) max = item;
                sum += item;
            }
            average = (double)sum / arr.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
            Console.WriteLine(string.Join(", ", arr));

        }
    }
}
