using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            var lenght = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);
            Console.WriteLine($"Surface Area – {box.SurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea():f2}");
            Console.WriteLine($"Volume – {box.Volume():f2}");


        }
    }
}
