using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;



public class Car
{
    public string Title { get; set; }
    public string Color { get; set; }
    public double Volume { get; set; }
    public int Price { get; set; }
    public static List<Car> GetCars()
    {
        return new List<Car>
            {
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car{ Title = "Porsche", Color = "Black", Price = 891374, Volume=4.5 },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" },
                new Car {Title="BMW", Volume = 3.2, Price=34134, Color="Blue" }
            };
    }

    public static List<Car> LoadFromJson()
    {
        string res = File.ReadAllText("Save.txt");
        List<Car> cars = new List<Car>();
        cars = JsonConvert.DeserializeObject<List<Car>>(res);
        return cars;
    }

    public static void SaveToJson(List<Car> cars)
    {
        string res = JsonConvert.SerializeObject(cars, Formatting.Indented);
        File.WriteAllText("Save.txt", res);
    }
}


class Program
{
    static int Factorial(int x)
    {
        if (x == 0)
            return 1;
        return x * Factorial(x - 1);
    }
    public static void Main(string [] args)
    {
        System.Console.WriteLine("Hello world");
        System.Console.WriteLine("Mish commit"); 
        System.Console.WriteLine(Factorial(5));

        List<Car> cars = Car.GetCars();
        foreach (Car item in cars)
        {
            Console.WriteLine($"{item.Title} ");
        }
    }
   
    
}