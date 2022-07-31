using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var specialWords = new List<string>();
            var otherWords = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                if (Char.IsUpper(word[0]) && word.Length > 7 && (word.Contains('i') || word.Contains('I')))
                {
                    specialWords.Add(word);
                }
                else
                {
                    otherWords.Add(word);
                }
            }

            Console.Write("Special words: ");
            Console.WriteLine(string.Join(", ", specialWords));
            Console.Write("Other words: ");
            Console.WriteLine(string.Join(", ", otherWords));

        }
    }
}
