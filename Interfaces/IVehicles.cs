namespace Simple_Vehicle_System.Interfaces;

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
