using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../Program.cs"))
            {
                var lineContents = reader.ReadLine();
                using (var writer = new StreamWriter("../../Reversed.txt"))
                {
                    while (lineContents != null)
                    {
                        var reversed = new string(lineContents.Reverse().ToArray());
                        writer.WriteLine(reversed);
                        lineContents = reader.ReadLine();
                    }
                }
            }
        }
    }
}
