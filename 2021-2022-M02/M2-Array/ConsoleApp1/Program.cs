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
            var num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var k = int.Parse(Console.ReadLine());
            int[] sum = new int[num.Length];
            for (int i = 0; i < k; i++)
            {
                num = Rotate(num);
                sum = Sum(sum, num);
            }
            Console.WriteLine(string.Join(" ", sum));

        }

        static int[] Sum(int[] sum, int[] num)
        {
            var sum2 = new int[sum.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum2[i] = sum[i] + num[i];
            }
            return sum2;
        }

        static int[] Rotate(int[] num)
        {
            var part1 = num.Take(num.Length - 1).ToArray();
            var part2 = num.Skip(num.Length - 1).Take(1).ToArray();
            return part2.Concat(part1).ToArray();
        }
    }
}
