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
            var line = Console.ReadLine().Split().ToArray();
            var word1 = line[0].ToArray();
            var word2 = line[1].ToArray();
            Console.WriteLine(IsReplaceble(word1, word2));
        }

        static bool IsReplaceble(char[] word1, char[] word2)
        {
            
        }
    }
}
