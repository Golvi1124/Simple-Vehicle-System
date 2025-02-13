using Simple_Vehicle_System.Classes;
using Simple_Vehicle_System.Interfaces;

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