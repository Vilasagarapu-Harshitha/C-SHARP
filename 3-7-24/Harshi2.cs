using System;
class Harshi2{
static void Main(string[]args){
Console.WriteLine("enter string");
string s = Console.ReadLine();
double d=double.Parse(s);
Console.WriteLine(d);
Console.WriteLine(s.GetType());
Console.WriteLine(d.GetType());
}
}
