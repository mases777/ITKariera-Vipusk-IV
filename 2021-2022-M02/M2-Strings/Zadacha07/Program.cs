using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha07
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(Sum(a, b));
        }

        static string Sum(string a, string b)
        {
            string c = "";
            if (a.Length < b.Length)
            {
                a = new string('0', b.Length - a.Length) + a;
            }
            else
            {
                b = new string('0', a.Length - b.Length) + b;
            }
            int part = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                int sum = (int)a[i] + (int)b[i] - 96; // ASCII
                if (part > 0)
                {
                    sum += part;
                    part = 0;
                }
                if (sum > 9)
                {
                    part = sum / 10;
                    sum = sum % 10;
                }
                c += sum.ToString();
            }
            return string.Join("", c.Reverse());
        }
    }
}
