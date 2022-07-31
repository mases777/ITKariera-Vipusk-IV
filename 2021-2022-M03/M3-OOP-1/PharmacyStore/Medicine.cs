using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Medicine
{
    private string name;
    private double price;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }    

    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid price");
            }
            price = value;
        }
    }

    public Medicine(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"Medicine: {Name} with price {Price:f2}";
    }
}

