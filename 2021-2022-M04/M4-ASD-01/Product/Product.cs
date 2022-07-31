using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private string name;
        private Product next;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public Product Next
        {
            get { return next; }
            set { next = value; }
        }

        public Product(string name)
        {
            this.name = name;
            this.next = null;
        }
        public Product(string name, Product product)
        {
            this.name = name;
            this.next = product;
        }

        public override string ToString()
        {
            return $"Product {this.Name}";
        }
    }
}
