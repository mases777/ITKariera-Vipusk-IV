﻿using System;
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
            int[] numbers = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(x => x += 1).ToArray();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    case "multiply":
                        numbers = numbers.Select(x => x *= 2).ToArray();
                        break;
                    case "substract":
                        numbers = numbers.Select(x => x -= 1).ToArray();
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
