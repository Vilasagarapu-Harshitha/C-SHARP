using System;

sealed class Science
{
    public static void Newton(double mass, double acceleration)
    {
        double force = mass * acceleration;
        Console.WriteLine("After applying Newton's law, force F = "+force);
    }

    public static void Einstein(double mass, double speedOfLight)
    {
        double energy = mass * Math.Pow(speedOfLight, 2);
        Console.WriteLine("After applying Einstein's law, Energy E ="+energy);
    }
}

class Harshi18
{
    static void Main(string[] args)
    {
        if (args.Length == 2)
        {
            double mass = double.Parse(args[0]);
            double acceleration = double.Parse(args[1]);

            Science.Newton(mass, acceleration);
            Science.Einstein(mass, acceleration); 
        }
        else
        {
            Console.WriteLine("Please provide exactly two command line arguments.");
        }
    }
}