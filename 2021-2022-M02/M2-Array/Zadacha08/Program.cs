using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split().ToArray();
            //var n = int.Parse(Console.ReadLine());
            var cmd = Console.ReadLine()
                    .Split().ToArray();
            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "Reverse": arr = arr.Reverse().ToArray(); break;
                    case "Distinct": arr = arr.Distinct().ToArray(); break;
                    case "Replace":
                        {
                            int index = int.Parse(cmd[1]);
                            if (index < 0 ||
                                index>= arr.Length)
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            else
                            {
                                arr[index] = cmd[2];
                            }
                        }
                         break;
                    default: Console.WriteLine("Invalid input!"); break;
                }
                cmd = Console.ReadLine()
                    .Split().ToArray();
            }
               
                
            
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
