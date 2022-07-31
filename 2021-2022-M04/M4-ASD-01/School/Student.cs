using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Student()
        {

        }

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"Student {this.Name} has {this.Grade:f2}.";
        }


    }
}
