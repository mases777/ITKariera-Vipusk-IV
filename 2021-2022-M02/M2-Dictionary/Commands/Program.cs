using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split().Select(int.Parse).ToList();
            var commands = Console.ReadLine().Split().ToList();

            while (commands[0] != "print")
            {
                if (commands[0] == "push") items.Add(int.Parse(commands[1]));
                else if (commands[0] == "pop")
                {
                    Console.WriteLine(items[items.Count - 1]);
                    items.RemoveAt(items.Count - 1);
                }
                else if (commands[0] == "shift")
                {

                }
                else if (commands[0] == "addMany")
                {

                }
                else if (commands[0] == "remove")
                {

                }


                commands = Console.ReadLine().Split().ToList();
            }
            items.Reverse();
            Console.WriteLine(string.Join(", ", items));

        }
    }
}
