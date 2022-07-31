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
            List<int> nums = Console.ReadLine()
                .Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int min = nums[0], max = nums[0];
            foreach (var item in nums)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == min ||
                    nums[i] == max)
                    result.Add(nums[i]);
            }
            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
