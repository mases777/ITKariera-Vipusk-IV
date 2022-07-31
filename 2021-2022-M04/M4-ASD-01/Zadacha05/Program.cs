using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha05
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split().ToArray();
            // 2 + 5 + 10 - 2 - 1
            // 1 - 2 - 10 + 5 + 2  stack

            Stack<string> stack = new Stack<string>(line.Reverse());
            int sum = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    sum += int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    sum -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(sum);

        }
    }
}
