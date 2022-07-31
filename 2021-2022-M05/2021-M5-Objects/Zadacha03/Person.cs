using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha03
{
    public class Person : IComparable<Person>
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            private set { city = value; }
        }

        public Person(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
        }

        public int CompareTo(Person other)
        {
            int compared = this.Name.CompareTo(other.Name);
            if (compared == 0)
            {
                compared = this.Age.CompareTo(other.Age);
            }
            if (compared == 0)
            {
                compared = this.City.CompareTo(other.City);
            }
            return compared;
        }
    }
}
