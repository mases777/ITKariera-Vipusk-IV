using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxBasket = int.Parse(Console.ReadLine());

            var sneakers = taxBasket * 0.6;
            var outfit = sneakers * 0.8;
            var ball = outfit * 0.25;
            var accessories = ball * 0.2;
            var total = taxBasket + sneakers + outfit + ball + accessories;

            Console.WriteLine($"{total:f2}");

        }
    }
}
