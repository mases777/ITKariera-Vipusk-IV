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
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                family.AddMember
                    (
                    new Person()
                    {
                        Name = line[0],
                        Age = int.Parse(line[1])
                    }
                );
            }

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine(oldestPerson);
        }
    }
}
