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
            Func<int[]> input = () => Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

            int[] numbers = input();

            Func<int[], int> count = (nums) => nums.Count();
            Console.WriteLine(count(numbers));

            Func<int[], int> sum = (nums) => nums.Sum();
            Console.WriteLine(sum(numbers));
        }
    }
}
