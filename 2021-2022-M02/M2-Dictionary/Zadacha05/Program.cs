using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            var productNameQuantityDict = new Dictionary<string, long>();
            var productNamePriceDict = new Dictionary<string, double>();

            //var products = new Dictionary<string, KeyValuePair<double, int>>();
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "stocked")
            {
                var productName = line[0];
                var productPrice = double.Parse(line[1]);
                var productQuantity = long.Parse(line[2]);

                if (!productNameQuantityDict.ContainsKey(productName))
                {
                    productNameQuantityDict[productName] = 0;
                    productNamePriceDict[productName] = productPrice;
                }

                productNameQuantityDict[productName] += productQuantity;
                productNamePriceDict[productName] = productPrice;

                //if (!products.ContainsKey(line[0]))
                //{
                //    products.Add(line[0], new KeyValuePair<double, int>(double.Parse(line[1]), int.Parse(line[2])));
                //}
                //else
                //{
                //    if (!products[line[0]].ContainsKey(double.Parse(line[1])))
                //    {
                //        products[line[0]][double.Parse(line[1])] = 0;
                //    }

                //    result[name][price] += quantity;
                //}

                

                line = Console.ReadLine().Split().ToArray();
            }
            double total = 0;

            foreach (var product in productNamePriceDict)
            {
                foreach (var productQuantity in productNameQuantityDict)
                {
                    if (productQuantity.Key == product.Key)
                    {
                        var totalPrice = product.Value * productQuantity.Value;
                        total += totalPrice;
                        Console.WriteLine($"{product.Key}: " +
                                          $"${product.Value:f2} * {productQuantity.Value} = ${totalPrice:f2}");
                    }
                }
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:f2}");

            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.Key}: ${item.Value.Key:F2} * {item.Value.Value} = ${(item.Value.Key * item.Value.Value):F2}");
            //    total += item.Value.Key * item.Value.Value;
            //}
            //Console.WriteLine($"------------------------------\nGrand Total: ${total:F2}");
        }
    }
}
