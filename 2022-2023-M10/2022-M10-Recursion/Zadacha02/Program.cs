using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете цяло число А: ");
            int a = int.Parse(Console.ReadLine());            
            Console.Write("Въведете цяло число B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Най-големия общ делител на А и В е = {Gcd(a, b)}");
        }

        private static int Gcd(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return Gcd(a - b, b);
            }
            return Gcd(a, b - a);
        }
    }
}
