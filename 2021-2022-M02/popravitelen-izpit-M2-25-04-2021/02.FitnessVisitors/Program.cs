using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FitnessVisitors
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { ',', ' ' };
            List<string> visitors = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            string cmd;
            while ((cmd = Console.ReadLine()) != "END")
            {
                string name;
                int position;
                switch (cmd)
                {
                    case "Add visitor":
                        name = Console.ReadLine();
                        visitors.Add(name);
                        break;
                    case "Add visitor on position":
                        name = Console.ReadLine();
                        position = int.Parse(Console.ReadLine());
                        visitors.Insert(position, name);
                        break;
                    case "Remove visitor on position":
                        position = int.Parse(Console.ReadLine());
                        visitors.RemoveAt(position);
                        break;
                    case "Remove last visitor":
                        visitors.RemoveAt(visitors.Count - 1);
                        break;
                    case "Remove first visitor":
                        visitors.RemoveAt(0);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
