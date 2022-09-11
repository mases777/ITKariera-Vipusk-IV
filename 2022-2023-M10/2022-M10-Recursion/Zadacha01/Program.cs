using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете цяло число по-голямо от 2: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));
        }

        private static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
