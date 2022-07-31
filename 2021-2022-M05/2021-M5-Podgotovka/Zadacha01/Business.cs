using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha01
{
    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }
        public override string Name
        {
            get
            {
                return base.Name;
            }
            protected set
            {
                if (value.Split(' ').Last() != nameof(Business))
                {
                    throw new ArgumentException("Name of business buildings should end on Business!");
                }
                base.Name = value;
            }
        }
    }
}
