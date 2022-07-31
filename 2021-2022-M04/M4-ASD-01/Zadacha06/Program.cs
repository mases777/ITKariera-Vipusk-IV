using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            // 1 + (2 - (2 + 3) * 4 / (3 + 1)) * 5
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(') stack.Push(i);
                if (line[i] == ')')
                {
                    Console.WriteLine(line
                        .Substring(stack.Peek(), i - stack.Peek() + 1));
                    stack.Pop();
                }
            }

        }
    }
}
