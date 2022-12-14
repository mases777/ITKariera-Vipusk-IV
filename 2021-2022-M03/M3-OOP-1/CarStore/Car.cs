using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    private int number;
    private double price;
    public int Number
    {
        get { return number; }
        set { number = value; }
    }    

    public double Price
    {
        get { return price; }
        set {
            if (value < 1000)
            {
                throw new ArgumentException("Invalid car price!");
            }
            price = value; }
    }

    public Car(int number, double price)
    {
        this.Number = number;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"Car number {this.Number} costs {this.Price:f2}";
    }

}

