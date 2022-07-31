using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split();
                switch (cmd[0])
                {
                    case "Circle":
                        {
                            Circle circle = new Circle(cmd[1], double.Parse(cmd[2]));
                            System.Console.WriteLine($"{circle.GetName()}");
                            circle.Show();
                            System.Console.WriteLine($"Area: {circle.GetArea()}");
                            break;
                        }
                    case "Square":
                        {
                            Square square = new Square(cmd[1], double.Parse(cmd[2]));
                            System.Console.WriteLine($"{square.GetName()}");
                            square.Show();
                            System.Console.WriteLine($"Area: {square.GetArea()}");
                            break;
                        }
                    case "Triangle":
                        {
                            Triangle triangle = new Triangle(cmd[1], double.Parse(cmd[2]));
                            System.Console.WriteLine($"{triangle.GetName()}");
                            triangle.Show();
                            System.Console.WriteLine($"Area: {triangle.GetArea()}");
                            break;
                        }
                }
            }
        }
    }
}
