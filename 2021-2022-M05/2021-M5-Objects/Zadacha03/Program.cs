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
            List<Person> people = new List<Person>();
            var command = Console.ReadLine();
            while (command != "END")
            {
                var cmd = command.Split().ToArray();
                people.Add(new Person(cmd[0], int.Parse(cmd[1]), cmd[2]));
                command = Console.ReadLine();
            }
            int n = int.Parse(Console.ReadLine());
            Person searched = people[n - 1];
            int matches = 0;
            foreach (var item in people)
            {
                if (item.CompareTo(searched) == 0)
                {
                    matches++;
                }
            }

            if (matches != 1)
            {
                Console.WriteLine($"{matches} {people.Count-matches} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
