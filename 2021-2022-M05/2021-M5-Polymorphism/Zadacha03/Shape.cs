﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    public abstract class Shape
    {
        public abstract double calculatePerimeter();
        public abstract double calculateArea();
        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
