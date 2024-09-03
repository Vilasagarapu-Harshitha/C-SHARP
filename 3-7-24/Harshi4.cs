using System;
class Harshi4{
static void Main(string[]args){
Console.WriteLine("Enter short:");
short a=short.Parse(Console.ReadLine());
char c=(char)a;
Console.WriteLine(c);
Console.WriteLine(c.GetType());
}
}