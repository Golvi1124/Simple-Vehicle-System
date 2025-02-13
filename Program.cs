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
            new Bus(90),
            new ElectricCar(99)
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.GetType().Name}"); // now dynamically printed
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

interface IElectricVehicle
{
    int BatteryLevel { get; set; }
}
/* 
Created a Base Class (Vehicle)
Now Car, Bike, and Truck inherit from Vehicle, reducing code repetition.
 */
abstract class Vehicle : IVehicle // An abstract class cannot be instantiated directly. It is meant to be a blueprint for other classes.
// Vehicle has common properties for all vehicle types (Speed, Wheels, Start(), Stop()).
// However, we don’t want to create a generic Vehicle object because every vehicle should be either a Car, Bike, or Truck.
{
    public int Speed { get; set; } // get and set - to be able to change later. If want to assig only during construction, use public int Speed { get; init; }
    public int Wheels { get; } // using without Setter to make property read-only/fixed after initialization. (e.g. car always has 4 wheels)

    protected Vehicle(int speed, int wheels) // A protected constructor means that only derived classes (subclasses) can call it.
    { // The Vehicle class is a base class (it should not be instantiated directly).
      // Car, Bike, and Truck are subclasses that should set values for speed and wheels.
      // The renaming avoids confusion between the constructor parameters (speed, wheels) and the class properties (Speed, Wheels).
        Speed = speed;
        Wheels = wheels;
    }
    public abstract void Start(); // now must be implemented by subclasses. must be customized by each vehicle type. 
    // when adding ElectricCar don’t have to modify IVehicle, just the class hierarchy.
    public virtual void Stop() // default behavior
    {
        Console.WriteLine($"{GetType().Name} has stopped.");
    }
}

class Car : Vehicle
{
    public Car(int speed) : base(speed, 4) { }

    public override void Start()
    {
        Console.WriteLine("Car has started.");
        Console.WriteLine($"Speed: {Speed}, Wheels: {Wheels}");
    }

}

class Bike : Vehicle
{
    public Bike(int speed) : base(speed, 2) { }
    /* 
    Bike constructor:
    It takes one parameter (speed) but does not define wheels explicitly.
    The base(speed, 2) part calls the Vehicle constructor, passing:
        - speed (whatever value was provided when creating the Bike)
        - 2 (because a bike always has 2 wheels)

    What does base(speed, 2) do?
    - Call the Vehicle constructor.
    - Pass speed and 2 to the base constructor (Vehicle(int speed, int wheels)).
    - Assign those values to the Vehicle class properties (Speed and Wheels).
    - 50 is passed to the Bike constructor.
    - The Bike constructor doesn't do anything itself, but it forwards the values to the Vehicle constructor: base(50, 2);
    - This assigns:
        Speed = 50;
        Wheels = 2;
     */
    public override void Start()
    {
        Console.WriteLine("Bike has started.");
        Console.WriteLine($"Speed: {Speed}, Wheels: {Wheels}");
    }
}

class Truck : Vehicle
{
    public Truck(int speed) : base(speed, 6) { }
    public override void Start()
    {
        Console.WriteLine("Truck has started.");
        Console.WriteLine($"Speed: {Speed}, Wheels: {Wheels}");
    }

}

class Bus : Vehicle
{
    public Bus(int speed) : base(speed, 8) { }
    public override void Start()
    {
        Console.WriteLine("Bus has started.");
        Console.WriteLine($"Speed: {Speed}, Wheels: {Wheels}");
    }
}

class ElectricCar : Vehicle, IElectricVehicle
{
    public ElectricCar(int speed) : base(speed, 4) { }
    public int BatteryLevel { get; set; } = 46;
    public override void Start()
    {
        Console.WriteLine("Electric car has started.");
        Console.WriteLine($"Battery level is at {BatteryLevel} %");
        Console.WriteLine($"Speed: {Speed}, Wheels: {Wheels}");
    }

    public override void Stop() // adding custom behavior
    {
        Console.WriteLine("Electric car has stopped and is regenerating battery.");

    }
}