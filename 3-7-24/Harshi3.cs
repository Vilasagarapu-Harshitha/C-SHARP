using System;
class Harshi3{
static void Main(string[]args){
double a=double.Parse(Console.ReadLine());
int i=(int)a;
short s=(short)a;
Console.WriteLine(a);
Console.WriteLine(s);
Console.WriteLine(i);
Console.WriteLine(a.GetType());
Console.WriteLine(i.GetType());
Console.WriteLine(s.GetType());
}
}