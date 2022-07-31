using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfWord = int.Parse(Console.ReadLine());
            List<string> specialWordsLetter = new List<string>();
            List<string> specialWordsA = new List<string>();
            List<string> otherWords = new List<string>();
            for (int i = 0; i < numbersOfWord; i++)
            {
                string word = Console.ReadLine();
                if (word[0] == word[word.Length - 1]) specialWordsLetter.Add(word);
                int letterA = 0;
                foreach (var item in word) if (item == 'a') letterA++;
                if (letterA >= 2) specialWordsA.Add(word);
                if (word[0] != word[word.Length - 1] && letterA < 2) otherWords.Add(word);
            }
            Console.WriteLine(string.Join(", ", specialWordsLetter));
            Console.WriteLine(string.Join(", ", specialWordsA));
            Console.WriteLine(string.Join(", ", otherWords));
        }
    }
}
