using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
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
            string result = "";
            while (number > 0)
            {
                var remainder = number % target;
                result = string.Concat(remainder.ToString(), result);
                number = number / target;
            }
            return result;
        }
    }
}
