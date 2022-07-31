using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            var basket = new Dictionary<string, int>();
            var line = Console.ReadLine();
            while (line != "END")
            {
                var command = line.Split('-', (char)StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = command[0];
                var points = int.Parse(command[1]);
                if (basket.ContainsKey(name))
                    basket[name] += points;
                else
                    basket.Add(name, points);

                line = Console.ReadLine();
            }

            foreach (var item in basket.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


            //string line;
            //while ((line = Console.ReadLine()) != "END")
            //{


            //}

        }
    }
}
