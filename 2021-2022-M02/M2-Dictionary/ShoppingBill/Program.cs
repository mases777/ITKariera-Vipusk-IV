using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBill
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Dictionary<string, double>();
            var line = Console.ReadLine();
            double totalSum = 0;
            while (line != "STOP SHOPPING")
            {
                var command = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = command[0];
                var price = double.Parse(command[1]);
                totalSum += price;
                if (shop.ContainsKey(name))
                    shop[name] += price;
                else
                    shop.Add(name, price);

                line = Console.ReadLine();
            }

            foreach (var item in shop.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
            Console.WriteLine($"Total sum: {totalSum:f2}");

        }
    }
}
