using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha09
{
    class Chicken
    {
        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "" || value.Trim().Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }


        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 15)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }
                age = value;
            }
        }

        public string CalculateProductPerDay()
        {
            //Chicken Mara (age 10) can produce 1 eggs per day.
            return $"Chicken {this.name} (age {this.age}) can produce 1 eggs per day.";
        }

    }
}
