using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha06
{
    class Tyres
    {
        private double naliagane;

        public double Naliagane
        {
            get { return naliagane; }
            set { naliagane = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Tyres(double naliagane, int age)
        {
            this.naliagane = naliagane;
            this.age = age;
        }
    }
}
