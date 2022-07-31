using System;
using Tesseract;

namespace Tesseract3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = AppContext.BaseDirectory;
            string fileName = filePath + "tessdata\\test.png";
            //string fileName = @"F:\repos\2022-M07-Nuget\Tesseract2\tessdata\test.png";
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