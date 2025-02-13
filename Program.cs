namespace Simple_Vehicle_System;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();
        Truck truck = new Truck();

        List<IVehicle> vehicles = new List<IVehicle>();
        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(truck);

        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();
        }
    }
}

interface IVehicle
{
    int Speed { get; set; }
    int Wheels { get; set; }
    void Start();
    void Stop();
}

class Car : IVehicle
{
    public int Speed { get; set; } = 100;
    public int Wheels { get; set; } = 4;

    public void Start()
    {
        Console.WriteLine("Car has started.");
        Console.WriteLine($"Speed: {Speed}");
    }

    public void Stop()
    {
        Console.WriteLine("Car has stopped.");
    }
}

class Bike : IVehicle
{
    public int Speed { get; set; } = 50;
    public int Wheels { get; set; } = 2;

    public void Start()
    {
        Console.WriteLine("Bike has started.");
        Console.WriteLine($"Speed: {Speed}");
    }

    public void Stop()
    {
        Console.WriteLine("Bike has stopped.");
    }
}

class Truck : IVehicle
{
    public int Speed { get; set; } = 80;
    public int Wheels { get; set; } = 6;

    public void Start()
    {
        Console.WriteLine("Truck has started.");
        Console.WriteLine($"Speed: {Speed}");
    }

    public void Stop()
    {
        Console.WriteLine("Truck has stopped.");
    }
}