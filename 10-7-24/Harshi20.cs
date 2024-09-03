using System;
interface Bike{
void bikeavgspeed();
}
interface Car{
void caravgspeed();
}
class Vehicle:Bike,Car{
public void bikeavgspeed(){
Console.WriteLine("Enter bike distance");
double bikedis=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter bike time");
double biketime=Convert.ToDouble(Console.ReadLine());
double bspeed=(bikedis/biketime);
Console.WriteLine("Speed of bike:"+bspeed);
}
public void caravgspeed(){
Console.WriteLine("Enter car distance");
double cardis=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter car time");
double cartime=Convert.ToDouble(Console.ReadLine());
double cspeed=cardis/cartime;
Console.WriteLine("Speed of car:"+cspeed);
}
}
class Harshi20{
static void Main(String[] args){
Vehicle v=new Vehicle();
v.bikeavgspeed();
v.caravgspeed();
}
}