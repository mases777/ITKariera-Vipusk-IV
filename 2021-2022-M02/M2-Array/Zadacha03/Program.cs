using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {input[i] - 97}");
            }
        }
    }
}
