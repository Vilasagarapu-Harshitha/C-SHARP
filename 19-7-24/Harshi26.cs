using System;
using System.Collections.Generic;

class Harshi26
{
    static void Main()
    {
        List<Fruit> fruits = new List<Fruit>();
        string command;

        do
        {
            Console.WriteLine("Enter a fruit name (or type 'exit' to finish):");
            command = Console.ReadLine();

            if (command.ToLower() != "exit")
            {
                Console.WriteLine("Enter the quantity of this fruit:");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    fruits.Add(new Fruit { Name = command, Quantity = quantity });
                    Console.WriteLine("Fruit added successfully.\n");
                }
                else
                {
                    Console.WriteLine("Invalid quantity. Please try again.\n");
                }
            }
        } while (command.ToLower() != "exit");

        Console.WriteLine("\nList of fruits in the inventory:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"{fruit.Name} - Quantity: {fruit.Quantity}");
        }
    }
}