using Simple_Vehicle_System.Interfaces;

namespace Simple_Vehicle_System.Classes;

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
