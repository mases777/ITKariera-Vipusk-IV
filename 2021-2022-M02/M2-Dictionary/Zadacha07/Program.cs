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
            var phonebook = new SortedDictionary<string, string>();
            var line = Console.ReadLine().Split().ToArray();
            while (line[0] != "END")
            {
                switch (line[0])
                {
                    case "A":
                        {
                            phonebook[line[1]] = line[2];
                            break;
                        }
                    case "S":
                        {
                            if (phonebook.ContainsKey(line[1]))
                            {
                                var phone = phonebook[line[1]];
                                Console.WriteLine($"{line[1]} -> {phone}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {line[1]} does not exist.");
                            }
                            break;
                        }
                    case "ListAll":
                        {
                            foreach (var item in phonebook.Keys)
                            {
                                Console.WriteLine($"{item} -> {phonebook[item]}");
                            }
                            break;
                        }
                }

                line = Console.ReadLine().Split().ToArray();
            }

        }
    }
}
