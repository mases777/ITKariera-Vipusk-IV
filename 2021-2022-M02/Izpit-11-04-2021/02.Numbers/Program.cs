using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> evenNumber = new List<int>();
            List<int> oddNumber = new List<int>();
            List<int> number5 = new List<int>();
            foreach (var item in numbers)
            {
                if (EvenNumber(item)) evenNumber.Add(item);
                if (OddNumber(item)) oddNumber.Add(item);
                if (NumberSum(item, 5)) number5.Add(item);                
            }
            Console.WriteLine(string.Join(", ", evenNumber));
            Console.WriteLine(string.Join(", ", oddNumber));
            Console.WriteLine(string.Join(", ", number5));

        }
        private static bool NumberSum(int item, int k)
        {
            int sum = 0;
            while (item > 0)
            {
                sum += item % 10;
                item = item / 10;
            }
            if (sum % 10 == k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool OddNumber(int item)
        {
            if (item % 2 == 1)
            {
                return true;
            }
            return false;
        }
        private static bool EvenNumber(int item)
        {
            if (item % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
