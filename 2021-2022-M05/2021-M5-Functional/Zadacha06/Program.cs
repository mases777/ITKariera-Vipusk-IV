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
            Func<int[]> input = () => Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            Action<int[]> output = (x) => Console.WriteLine(x.Min());
            output(input());
        }
    }
}
