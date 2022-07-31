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
            //int n = int.Parse(Console.ReadLine());
            //List<int> nums = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    nums.Add(int.Parse(Console.ReadLine()));
            //}
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine($"list[{i}] = {nums[i]}");
            //}

            List<int> nums2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums2.Reverse();
            Console.WriteLine(string.Join(", ", nums2));
        }
    }
}
