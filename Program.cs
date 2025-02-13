namespace Simple_Vehicle_System;

class Program
{
    static void Main(string[] args)
    {
        List<IVehicle> vehicles = new List<IVehicle>
        {
            new Car(100),
            new Bike(50),
            new Truck(80),
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}"); // ...why get type?
            vehicle.Start();
            vehicle.Stop();
            Console.WriteLine(new string('-', 30)); // Found new way to make output easier to read ^^
        }
    }
}

interface IVehicle
{
    int Speed { get; set; }
    int Wheels { get; }
    void Start();
    void Stop();
}
/* 
Created a Base Class (Vehicle)
Now Car, Bike, and Truck inherit from Vehicle, reducing code repetition.
 */
abstract class Vehicle : IVehicle // .....why abstract class?
{
    public int Speed { get; set; }
    public int Wheels { get; } // .....why only getter?

    protected Vehicle(int speed, int wheels) // .....why protected? and why in general?
    {
        Speed = speed;
        Wheels = wheels;
    }
    public virtual void Start()
    {
        Console.WriteLine($"{GetType().Name} has started.");
        Console.WriteLine($"Speed: {Speed} hm/h, wheels: {Wheels}");
    }
    public virtual void Stop()
    {
        Console.WriteLine($"{GetType().Name} has stopped.");
    }
}

class Car : Vehicle
{
    public Car(int speed) : base(speed, 4) {} // ....what does it all mean?
}

class Bike : Vehicle
{
    public Bike(int speed) : base(speed, 2) {}
}

class Truck : Vehicle
{
    public Truck(int speed) : base(speed, 6) {}
}