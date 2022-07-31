using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha08
{
    class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }
        public double SurfaceArea()
        {
            return 2 * this.lenght * this.width +
                   2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height +
                   2 * this.width * this.height;
        }

        public double Volume()
        {
            return this.lenght * this.width * this.height;
        }
    }
}
