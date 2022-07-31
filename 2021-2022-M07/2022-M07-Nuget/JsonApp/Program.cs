using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Test product", 100.01m, 100, new DateTime(2022, 02, 19));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product object:");
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            List<Product> products = new List<Product>()
            {
                new Product(1, "Milk", 2.59m, 200, new DateTime(2021, 05, 30)),
                new Product(2, "Lyutenica", 2.39m, 150, new DateTime(2020, 01, 12)),
                new Product(3, "Rice", 1.65m, 250, new DateTime(2021, 12, 16)),
                new Product(4, "Salt", 3.14m, 340, new DateTime(2022, 01, 26)),
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("List of products:");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-', 50));

            string jsonSizes = @"['Small','Medium','Large']";
            var objectSizes = JsonConvert.DeserializeObject(jsonSizes);
            var a = JArray.Parse(jsonSizes);
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(string.Join(" ", objectSizes));
        }
    }
}
