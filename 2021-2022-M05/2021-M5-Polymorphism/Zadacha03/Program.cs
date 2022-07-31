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
            Shape circle = new Circle(3.0);
            Console.WriteLine(circle.Draw());
            Console.WriteLine($"Perimeter = {circle.calculatePerimeter():f2}");
            Console.WriteLine($"Area = {circle.calculateArea():f2}");

            Shape rect = new Rectangle(2.3, 3.0);
            Console.WriteLine(rect.Draw());
            Console.WriteLine($"Perimeter = {rect.calculatePerimeter():f2}");
            Console.WriteLine($"Area = {rect.calculateArea():f2}");
        }
    }
}
