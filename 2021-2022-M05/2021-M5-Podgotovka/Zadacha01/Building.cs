using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public abstract class Building
    {
        private string name;

        public virtual string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Building name must not be null or empty!");
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
        private int stars;

        public int Stars
        {
            get { return stars; }
            set
            {
                if (value < 0 || value > 5)
                {
                    throw new ArgumentException("Stars cannot be less than 0 or above 5!");
                }
                stars = value;
            }
        }
        private double rentAmount;

        public double RentAmount
        {
            get { return rentAmount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rent amount cannot be less or equal to 0!");
                }
                rentAmount = value;
            }
        }
        public bool IsAvailable { get; set; }

        protected Building(string name, string city, int stars, double rentAmount)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.RentAmount = rentAmount;
            this.IsAvailable = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"****Building: {this.Name} <{this.Stars}>");
            sb.AppendLine($"****Location: {this.City}");
            sb.AppendLine($"****RentAmount: {this.RentAmount}");
            sb.AppendLine($"****Is Available: {this.IsAvailable}");
            
            return sb.ToString().TrimEnd();
        }
    }
}
