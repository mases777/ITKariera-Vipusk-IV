using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int target = line[0];
            int number = line[1];
            Console.WriteLine(Convert10(number, target));
        }

        static string Convert10(int number, int target)
        {
            double sum = 0, pow = 0;
            while (number > 0)
            {
                var current = number % 10;
                sum += current * Math.Pow(target, pow);
                pow++;
                number /= 10;
            }
            return sum.ToString();
        }
    }
}
