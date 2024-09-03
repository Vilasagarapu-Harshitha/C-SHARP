using System;
using System.Collections.Generic;

class Harshi27
{
    static void Main()
    {
        List<Attendee> attendees = new List<Attendee>();
        string command;

        Console.WriteLine("Welcome to the Birthday Celebration Event!");

        do
        {
            Console.WriteLine("Enter the name of the attendee (or type 'exit' to finish):");
            command = Console.ReadLine();

            if (command.ToLower() != "exit")
            {
                Console.WriteLine("Enter the age of this attendee:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    attendees.Add(new Attendee { Name = command, Age = age });
                    Console.WriteLine("Attendee added successfully.\n");
                }
                else
                {
                    Console.WriteLine("Invalid age. Please try again.\n");
                }
            }
        } while (command.ToLower() != "exit");

        Console.WriteLine("\nCelebrating Birthdays of Attendees:");
        foreach (var attendee in attendees)
        {
            CelebrateBirthday(attendee);
        }
    }

    static void CelebrateBirthday(Attendee attendee)
    {
        Console.WriteLine($"Happy Birthday, {attendee.Name}! You are now {attendee.Age + 1} years old!");
    }
}

class Attendee
{
    public string Name { get; set; }
    public int Age { get; set; }
}