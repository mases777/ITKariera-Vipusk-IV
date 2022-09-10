using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int r = 0;

            while (p > 1)
            {
                r = (p + q) / p;
                Console.Write($"1/{r} + ");
                p = p * r - q;
                q = q * r;
                int m = Gcd(p, q);
                p /= m;
                q /= m;
            }
            Console.WriteLine($"1/{q}");
        }

        private static int Gcd(int p, int q)
        {
            if (p > q)
            {
                return Gcd(p - q, q);
            }
            else if (q > p)
            {
                return Gcd(p, q - p);
            }
            return p;
        }
    }
}
