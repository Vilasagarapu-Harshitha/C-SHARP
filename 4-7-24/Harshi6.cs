using System;
class Harshi6
{
static void Main()
{
Console.Write("Enter your name: ");
string name = Console.ReadLine();
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Hello" +name+"!");
Console.WriteLine("You are"+ age+"years old.");
int currentYear = DateTime.Now.Year;
int birthYear = currentYear - age;
Console.WriteLine("You were born in the year "+birthYear);
if (age < 18)
{
Console.WriteLine("You are a minor.");
}
else if (age >= 18 && age <= 65)
{
Console.WriteLine("You are an adult.");
}
else
{
Console.WriteLine("You are a senior citizen.");
}
}
}