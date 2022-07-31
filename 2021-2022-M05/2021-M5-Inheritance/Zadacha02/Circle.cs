using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(base.size, 2.0), 2);
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
