using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Store
{
    private string name;
    private List<Car> cars;
    public string Name
    {
        get { return name; }
        set {
            if (value.Length < 5)
            {
                throw new ArgumentException("Invalid store name!");
            }
            name = value; }
    }    

    public IReadOnlyList<Car> Cars
    {
        get { return cars; }
    }

    public Store(string name)
    {
        this.Name = name;
        this.cars = new List<Car>();
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public bool SellCar(Car car)
    {
        Car newCar = cars.Find(x => x.Number == car.Number);
        if (newCar != null)
        {
            cars.Remove(newCar);
            return true;
        }
        return false;        
    }

    public double CalculateTotalPrice()
    {
        return cars.Select(x => x.Price).Sum();
    }

    public Car GetCarWithHighestPrice()
    {
        return cars.OrderByDescending(x => x.Price).FirstOrDefault();
    }

    public Car GetCarWithLowestPrice()
    {
        return cars.OrderBy(x => x.Price).FirstOrDefault();
    }

    public void RenameStore(string newName)
    {
        this.Name = newName;
    }

    public void SellAllCars()
    {
        cars.Clear();
    }

    public override string ToString()
    {
        string answer = $"Store {Name} has {Cars.Count} car/s:";
        if (Cars.Count > 0)
        {
            foreach (var item in cars)
            {
                answer += $"\nCar number {item.Number} costs {item.Price:f2}";
            }
            return answer;
        }
        return $"Store {Name} has no available cars.";
    }

}

