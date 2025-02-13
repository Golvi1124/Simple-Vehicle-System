using Simple_Vehicle_System.Interfaces;

namespace Simple_Vehicle_System.Classes;

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
