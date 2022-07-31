using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    class Program
    {
        static void Main(string[] args)
        {
           var nums = Console.ReadLine()
                .Split('|').ToList();
            List<int> result = new List<int>();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                List<string> words = nums[i].Split(' ').ToList();
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j] != "")
                    {
                        result.Add(int.Parse(words[j]));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
