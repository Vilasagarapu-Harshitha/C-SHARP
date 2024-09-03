using System;

namespace VIS
{
    abstract class Vehicle
    {
        public abstract void Description(int wheels, string vehicleType);
    }

    class Category : Vehicle
    {
        public override void Description(int wheels, string vehicleType)
        {
            Console.WriteLine("The number of wheels in a"+vehicleType+"are"+wheels);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                int wheels = int.Parse(args[0]);
                string vehicleType = args[1];

                Vehicle vehicle = new Category();
                vehicle.Description(wheels, vehicleType);
            }
            else
            {
                Console.WriteLine("Please provide the correct number of arguments: <wheels> <vehicleType>");
            }
        }
    }
}
