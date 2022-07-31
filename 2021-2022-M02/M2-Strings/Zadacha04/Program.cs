using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            Console.WriteLine(StringReverse(line));
        }

        static string StringReverse(string line)
        {
            string result = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                result = string.Concat(result, line[i].ToString());
            }
            return result;
        }
    }
}
