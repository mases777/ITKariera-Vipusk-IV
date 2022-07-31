using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../input1.txt"))
            {
                var line0 = reader.ReadLine();
                var line1 = reader.ReadLine();
                while (line0 != null)
                {
                    Console.WriteLine(line0);
                    line0 = reader.ReadLine();
                    line1 = reader.ReadLine();
                }
            }
        }
    }
}
