using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha04
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            using (var words2 = new StreamReader("../../words2.txt"))
            {
                using (var text = new StreamReader("../../text.txt"))
                {
                    using (var writer = new StreamWriter("../../result.txt"))
                    {
                        var line = text.ReadToEnd().ToLower().Split(
                            ',', ' ', '?', '.', '-', '!', ';').ToArray();
                        var search = words2.ReadLine();
                        while (search != null)
                        {
                            dict.Add(search, line.Count(x => x == search));
                            search = words2.ReadLine();
                        }
                        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        foreach (var item in dict)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
