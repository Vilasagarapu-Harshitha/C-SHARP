using System;
class Harshi1{
static void Main(string[]args){
double a=double.Parse(Console.ReadLine());
long b=(long)a;
float f =(float)b;
int i=(int)f;
Console.WriteLine(b);
Console.WriteLine(f);
Console.WriteLine(i);
Console.WriteLine(b.GetType());
Console.WriteLine(f.GetType());
Console.WriteLine(i.GetType());
}
}
