//Multicasting Delegation
/*used for calling more than 2 times. uses FIFO .uses multiple references .extension of delegation .*/
 
//Program
using System;
class H30{
public delegate void Rect(double height,double width);
public void area(double height,double width){
Console.WriteLine(height*width);
}
public void perimeter(double height,double width){
Console.WriteLine(2*(height+width));
}
static void Main(String[] args)
{
H30 t=new H30();
Rect r=new Rect(t.area);
r+=t.perimeter;
r.Invoke(4.5,7.8);
Console.WriteLine();
r.Invoke(3.4,1.2);
}
}



