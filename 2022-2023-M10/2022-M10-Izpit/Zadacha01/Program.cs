using System;
using System.Collections.Generic;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fufu = new List<string>();
            for (var i = 'a'; i <= 'z'; i++)
            {
                for (var j = 'a'; j <= 'z'; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    string word = i.ToString() + j.ToString();
                    fufu.Add(word);
                }
            }
            var line = Console.ReadLine();
            if (!fufu.Contains(line))
            {
                Console.WriteLine("No FuFu");
            }
            else
            {
                Console.WriteLine(fufu.IndexOf(line) + 1);
            }
        }



        //private static Dictionary<string, int> dict = new Dictionary<string, int>();
        //private static int counter = 1;
        //public static void Main(string[] args)
        //{
        //    for (char l1 = 'a'; l1 <= 'z'; l1++)
        //    {
        //        for (char l2 = 'a'; l2 <= 'z'; l2++)
        //        {
        //            if (l1 == l2)
        //            {
        //                continue;
        //            }

        //            dict.Add($"{l1}{l2}", counter++);
        //        }
        //    }

        //    var input = Console.ReadLine().Trim().ToLower();

        //    if (dict.ContainsKey(input))
        //    {
        //        Console.WriteLine(dict[input]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("No FuFu");
        //    }
        //}
    }
}
