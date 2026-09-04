public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();

        car.Brand = "BMW";

        car.Start();
        car.Drive();
    }
}

public class Vehicle
{
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine($"{Brand} vehicle started.");
    }
}

public class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine($"{Brand} car is driving.");
    }
}
