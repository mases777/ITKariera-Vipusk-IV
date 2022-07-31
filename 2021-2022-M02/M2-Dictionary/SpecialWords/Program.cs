using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialWords
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
                if (word[0] != word[word.Length-1] && word.Length > 5 && word.Contains('e'))
                {
                    specialWords.Add(word);
                }
                else
                {
                    otherWords.Add(word);
                }
            }

            Console.Write("Special words: ");
            Console.WriteLine(string.Join(",", specialWords));
            Console.Write("Other words: ");
            Console.WriteLine(string.Join(",", otherWords));


        }
    }
}
