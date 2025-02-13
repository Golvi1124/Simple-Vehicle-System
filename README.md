Wanted to become better in using Interfaces so asked ChatGPT to make me a task with vague instructions.

**Task: Create a Simple Vehicle System**

You need to create a basic system that manages different types of vehicles using classes and interfaces.
Steps (Vague Instructions)
1. Define an Interface
    Create an interface that represents a vehicle.
    It should have at least two properties and one method.
2. Create a Base Class
    Implement a base class that contains common properties for all vehicles.
3. Implement Derived Classes
    Create at least two different vehicle types that inherit from the base class and implement the interface.
4. Implement the Interface Methods
    Ensure each derived class provides its own version of the method(s) from the interface.
5. Write a Small Program
    In Main(), create objects of your vehicle classes.
    Store them in a collection (e.g., a List).
    Iterate through the collection and call the method(s) from the interface.
( init )

**Suggested Improvements**
1. Extract Common Functionality into a Base Class
    Since all vehicles have Speed, Wheels, Start(), and Stop(), you can create an abstract base class to reduce duplication.
2. Use Constructor Injection for Properties
    Instead of hardcoding Speed and Wheels, pass them through a constructor.
3. Enhance Output Readability
    Add a Name property to better distinguish each vehicle in the console output.
( 2 )

**Further Challenges**
1. Add another subclass, like Bus, with base(speed, 8).
2. Make Start() abstract and override it in Car, Bike, and Truck.
3. Add an IElectricVehicle interface with BatteryLevel and implement it in a new ElectricCar class.
4. Override Stop() for ElectricCar
    Since an electric car stops differently (e.g., regenerating energy), you can override Stop()
( 3 )
