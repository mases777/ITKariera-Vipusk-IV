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
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[nums.Length - 1];
            int n = nums.Length;
            do
            {
                for (int i = 0; i < n - 1; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                nums = condensed;
                n--;
            } while (n != 1);
            Console.WriteLine(condensed[0]);
        }
    }
}
