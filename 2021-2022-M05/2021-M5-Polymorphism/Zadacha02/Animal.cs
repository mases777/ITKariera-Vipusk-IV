using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha02
{
    public class Animal
    {
        protected string name { get; set; }
        protected string favoriteFood { get; set; }

        public Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }
        public virtual string ExplainMyself()
        {
            return $"I am {name} and my fovourite food is {favoriteFood}";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + "\n" + "MEEOW";
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + "\n" + "DJAAF";
        }
    }
}
