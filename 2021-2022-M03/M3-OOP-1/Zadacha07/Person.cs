using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha07
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.Age = age;
        }
        

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value.Length < 3)
                    Console.WriteLine("Greshka");
                else
                    firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            //Asen Harizanoov is a 44 years old
            return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
        }
    }
}
