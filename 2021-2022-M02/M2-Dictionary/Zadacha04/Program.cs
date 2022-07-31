﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            var ore = new Dictionary<string, int>();
            var resource = Console.ReadLine();
            while (resource != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());
                if (ore.ContainsKey(resource))
                {
                    ore[resource] += quantity;
                }
                else
                {
                    ore[resource] = quantity;
                }

                resource = Console.ReadLine();
            }

            foreach (var item in ore)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
