using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public abstract class ColoredFigure
    {
        protected string color;

        protected double size;

        protected ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine($"Color: {this.color}");
            Console.WriteLine($"Size: {this.size}");
        }
        public abstract string GetName();

        public abstract double GetArea();
    }
}
