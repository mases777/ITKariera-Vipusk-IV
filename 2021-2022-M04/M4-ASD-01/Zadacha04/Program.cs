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
            var line = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(line);
            string cmd;
            while ((cmd = Console.ReadLine().ToLower()) != "end")
            {
                var command = cmd.Split().ToArray();
                if (command[0] == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (command[0] == "remove")
                {
                    if (stack.Count >= int.Parse(command[1]))
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }            
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
