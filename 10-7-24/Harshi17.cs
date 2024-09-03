using System;

class Vehicle
{
    public sealed void StartEngine(string vType)
    {
        Console.WriteLine("The {vType} engine starts.");
    }
}

class Harshi17
{
    static void Main(string[] args)
    {
        string vType = args[0];
        Vehicle vehicle = new Vehicle();
        vehicle.StartEngine(vType);
    }
}
