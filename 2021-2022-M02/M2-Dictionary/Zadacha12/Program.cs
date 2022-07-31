using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split()
                .Select(x => DateTime.ParseExact(x, "HH:mm", null))
                .ToList().OrderBy(x => x);

            Console.WriteLine(string.Join(", ",
                times.Select(x => x.ToString("HH:mm"))));
        }
    }
}
