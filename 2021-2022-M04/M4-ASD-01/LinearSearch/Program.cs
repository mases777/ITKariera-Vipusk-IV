﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            var key = int.Parse(Console.ReadLine());
            int index = Search.Linear(nums, key);
            Console.WriteLine(index);


            //var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };

            //Console.WriteLine("Linear Search for Number [-3] ...");
            //if (Search.Linear(numbers, -3) == -1)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    Console.WriteLine("Found");
            //}

            //var alphas = new char[] { 'a', 'b', 'c', 'd', 'e' };
            //Console.WriteLine("Linear Search for Char ['z'] ...");
            //if (Search.Linear(alphas, 'z') == -1)
            //{
            //    Console.WriteLine("Not found");
            //}
            //else
            //{
            //    Console.WriteLine("Found");
            //}

        }
    }
}
