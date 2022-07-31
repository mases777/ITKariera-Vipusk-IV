using System;
using Tesseract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesseract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"F:\repos\2022-M07-Nuget\Tesseract\tessdata\test.png";
            using (var engine = new TesseractEngine(@"tessdata", "eng"))
            {
                using (var image = Pix.LoadFromFile(fileName))
                {
                    using (var page = engine.Process(image))
                    {
                        string text = page.GetText();
                        Console.WriteLine(text);
                    }
                }
            }
        }
    }
}
