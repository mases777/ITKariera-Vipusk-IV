using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            var evenNumber = new List<int>();
            var oddNumber = new List<int>();
            var number3 = new List<int>();
            var number6 = new List<int>();

            foreach (var item in numbers)
            {
                if (item % 10 == 2 || item % 10 == 4) evenNumber.Add(item);
                if (item % 10 == 5 || item % 10 == 7) oddNumber.Add(item);
                if (NumberSum(item, 3)) number3.Add(item);
                if (NumberSum(item, 6)) number6.Add(item);
            }

            Console.WriteLine(string.Join(",", evenNumber));
            Console.WriteLine(string.Join(",", oddNumber));
            Console.WriteLine(string.Join(",", number3));
            Console.WriteLine(string.Join(",", number6));

        }

        private static bool NumberSum(int item, int k)
        {
            int sum = 0;
            while (item > 0)
            {
                sum += item % 10;
                item = item / 10;
            }
            if (sum % 10 == k) return true;
            return false;
        }
    }
}
