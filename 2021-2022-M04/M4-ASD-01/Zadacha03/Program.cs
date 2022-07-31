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
            var line = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < line.Length; i++)
            {
                stack.Push(line[i].ToString());
            }
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
