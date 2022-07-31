using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesCount = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < clothesCount; i++)
            {
                var typeClothes = Console.ReadLine();
                switch (typeClothes)
                {
                    case "t-shirt": totalSum += 20; break;
                    case "jeans": totalSum += 50; break;
                    case "trainers": totalSum += 70; break;
                    case "jacket": totalSum += 60; break;
                }
            }

            Console.WriteLine($"{totalSum:f2}");

        }
    }
}
