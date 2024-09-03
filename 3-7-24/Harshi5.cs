using System;
class Harshi5{
static void Main(string[]args){
Console.WriteLine("Enter prinpaal amount");
double p=double.Parse(Console.ReadLine());
Console.WriteLine("Enter rate of i");
double r=double.Parse(Console.ReadLine());
Console.WriteLine("Enter time");
double y=double.Parse(Console.ReadLine());
double s=(p*r*y)/100;
Console.WriteLine(s);
}
}