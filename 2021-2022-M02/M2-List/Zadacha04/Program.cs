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
            List<int> nums = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            int start = 1, number = 0;
            int bestStart = 1;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                    start++;
                else start = 1;
                if (start > bestStart)
                {
                    bestStart = start;
                    number = nums[i];
                }
            }
            for (int i = 0; i < bestStart; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
