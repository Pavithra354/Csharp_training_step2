using InterfaceInheritanceExample;
using System;

namespace InterfaceInheritanceExample
{
    // Base interface 1
    interface IVehicle
    {
        int Wheels { get; set; }
        void Start();
        string GetInfo();
    }

    // Base interface 2
    interface IMaintenance
    {
        string ServiceSchedule();
    }

    // Child interface inheriting both
    interface ICar : IVehicle, IMaintenance
    {
        string FuelType(); // Rule: ICar must add its own member
    }
}
class Tesla : ICar
{
    public int Wheels { get; set; }

    public Tesla()
    {
        Wheels = 4;
    }

    public void Start()
    {
        Console.WriteLine("Tesla started silently.");
    }

    public string GetInfo()
    {
        return $"Tesla with {Wheels} wheels.";
    }

    public string ServiceSchedule()
    {
        return "Service every 12 months.";
    }

    public string FuelType()
    {
        return "Electric";
    }
}
class Program
{
    static void Main()
    {
        ICar myTesla = new Tesla();
        myTesla.Start();
        Console.WriteLine(myTesla.GetInfo());
        Console.WriteLine(myTesla.ServiceSchedule());
        Console.WriteLine($"Fuel Type: {myTesla.FuelType()}");
    }
}
