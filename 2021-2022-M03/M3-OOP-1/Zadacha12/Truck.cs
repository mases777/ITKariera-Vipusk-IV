using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha12
{
    class Truck
    {
        private string name;
        private int capacity;
        private List<Freight> freights;

        public Truck(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.freights = new List<Freight>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Truck capacity must be positive value.");
                }
                capacity = value;
            }
        }
        public IReadOnlyList<Freight> Freights
        {
            get { return freights; }
        }

        public void Add(Freight freight)
        {
            if (this.Capacity < freight.Weight)
            {
                throw new ArgumentException($"{this.Name} can't loaded {freight.Name}");
            }
            else
            {
                this.freights.Add(freight);
                Console.WriteLine($"{this.Name} loaded {freight.Name}");
            }
                
        }

        public override string ToString()
        {
            return this.Name + " - " + string.Join(", ", this.freights.Select(x => x.Name));
        }
    }
}
