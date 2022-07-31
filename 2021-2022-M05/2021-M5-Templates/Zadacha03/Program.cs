using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            // integer scale
            var intScale = new Scale<int>(32, 41);
            Console.WriteLine(intScale.GetHeavier());

            // string scale
            var stringScale = new Scale<string>("Ivan", "Peter");
            Console.WriteLine(stringScale.GetHeavier());

            // boolean scale
            var boolScale = new Scale<bool>(true, false);
            Console.WriteLine(boolScale.GetHeavier());

            // double scale
            var doubleScale = new Scale<double>(2.34, 3.45);
            Console.WriteLine(doubleScale.GetHeavier());

        }
    }
}
