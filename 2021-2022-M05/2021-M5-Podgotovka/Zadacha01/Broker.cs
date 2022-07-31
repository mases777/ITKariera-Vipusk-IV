using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Broker
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Broker name must not be null or empty!");
                }
                name = value;
            }
        }
        private string city;

        public string City
        {
            get { return city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City must not be null or empty!");
                }
                city = value;
            }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16 || value > 70)
                {
                    throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
                }
                age = value;
            }
        }
        private double bonus;
        private readonly List<Building> buildings;
        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.City = city;
            this.Age = age;
            this.buildings = new List<Building>();
        }

        public double ReceiveBonus(Building building)
        {
            this.buildings.Add(building);
            double currentBonus = (double)building.RentAmount * 2.0 * building.Stars / 100.0;
            bonus += currentBonus;
            return currentBonus;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Broker: {this.Name} <{this.Age}>");
            sb.AppendLine($"****Location: {this.City}");
            sb.AppendLine($"****Bonus: {this.bonus}");
            foreach (var item in buildings)
            {
                sb.AppendLine($"****** {item.Name}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
