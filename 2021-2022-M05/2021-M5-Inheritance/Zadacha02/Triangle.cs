using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.Round((Math.Pow(base.size, 2.0) * Math.Sqrt(3)) / 4.0, 2);
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
