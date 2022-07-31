using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            var evenNumber = new List<int>();
            var oddNumber = new List<int>();
            var number15 = new List<int>();

            foreach (var item in numbers)
            {
                if (EvenNumber(item)) evenNumber.Add(item);
                if (OddNumber(item)) oddNumber.Add(item);
                if (NumberSum(item)) number15.Add(item);
            }

            Console.WriteLine(string.Join(", ", evenNumber));
            Console.WriteLine(string.Join(", ", oddNumber));
            Console.WriteLine(string.Join(", ", number15));

        }

        private static bool NumberSum(int item)
        {
            int sum = 0;
            while (item > 0)
            {
                sum += item % 10;
                item = item / 10;
            }
            if (sum == 15) return true;
            return false;
        }

        private static bool OddNumber(int item)
        {
            if (item % 10 == 5 || item % 10 == 7)
            {
                return true;
            }
            return false;
        }

        private static bool EvenNumber(int item)
        {
            if (item % 10 == 4 || item % 10 == 8)
            {
                return true;
            }
            return false;
        }
    }
}
