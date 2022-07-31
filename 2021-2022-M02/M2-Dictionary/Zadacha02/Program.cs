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
            var line = Console.ReadLine().ToLower().Split().ToArray();
            var wordCounter = new Dictionary<string, int>();
            var oddCounter = new List<string>();

            foreach (var item in line)
            {
                if (wordCounter.ContainsKey(item))
                {
                    wordCounter[item]++;
                }
                else
                {
                    wordCounter[item] = 1;
                }
            }

            foreach (var item in wordCounter)
            {
                if (item.Value % 2 != 0)
                {
                    oddCounter.Add(item.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddCounter));

        }
    }
}
