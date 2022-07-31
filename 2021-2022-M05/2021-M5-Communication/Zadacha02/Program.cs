using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter filename to read: ");
            string fileName = Console.ReadLine();

            try
            {
                StreamReader reader = new StreamReader(fileName);
                using (reader)
                {
                    int lineNumber = 1;
                    string lineText = reader.ReadLine();
                    while (lineText != null)
                    {
                        Console.WriteLine($"{lineNumber}: {lineText}");
                        lineNumber++;
                        lineText = reader.ReadLine();
                    }
                }
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }
    }
}
