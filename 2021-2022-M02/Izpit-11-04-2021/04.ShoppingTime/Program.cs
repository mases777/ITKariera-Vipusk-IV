﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shop = new Dictionary<string, double>();
            string line;
            double totalSum = 0;
            while ((line = Console.ReadLine()) != "Stop shopping")
            {
                var command = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();
                string article = command[0];
                double price = double.Parse(command[1]);
                totalSum += price;
                if (shop.ContainsKey(article)) shop[article] += price;
                else shop.Add(article, price);
            }
            foreach (var item in shop.OrderBy(x => x.Value))
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            Console.WriteLine($"Total sum: {totalSum:f2}");
        }
    }
}
