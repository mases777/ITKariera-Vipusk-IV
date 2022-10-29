using System;

namespace Zadacha04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int br = 0;
            for (int i = 2; i <= 1000; i++)
            {
                if (PrimeNumber(i) || i == 2)
                {
                    br++;
                    Console.WriteLine(i);
                }
                if (br == n)
                {
                    return;
                }
            }

        }

        private static bool PrimeNumber(int a)
        {
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(a)); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
