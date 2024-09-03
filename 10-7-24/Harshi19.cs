using System;

public class Harshi19
{
    public static void Main(string[] args)
    {
       
        int x = int.Parse(args[0]);
        int y = int.Parse(args[1]);
        double z = double.Parse(args[2]);

        const int a = 45;
        const double b= 3.14;

        double result = x * y + a + b * z;

        Console.WriteLine("The result is " + result);
    }
}
