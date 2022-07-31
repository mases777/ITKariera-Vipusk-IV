using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurresction
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long totalLength = long.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long winLength = long.Parse(Console.ReadLine());

                decimal totalYears = (decimal)(totalLength * totalLength) * (totalWidth + 2 * winLength);
                Console.WriteLine(totalYears);
            }
        }
    }
}
