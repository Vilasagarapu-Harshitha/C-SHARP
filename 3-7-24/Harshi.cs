using System;
class Harshi{
static void Main(string[]args){
int a=int.Parse(Console.ReadLine());
long b=a;
float f =b;
double d=f;
Console.WriteLine(b);
Console.WriteLine(f);
Console.WriteLine(d);
Console.WriteLine(b.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(d.GetType());
}
}
