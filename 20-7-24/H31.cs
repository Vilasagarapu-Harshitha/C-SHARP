//custom delegation
/* declare a custom delegate with the format which is exactly equal to the method.
create the object of custom delegate.
invoke the method.*/
using System;
class H31{
public delegate int show(int a,int b,int c);
public static int display(int a,int b,int c){
return a+b*c;
}
static void Main(string[] args){
show s1=display;
Console.WriteLine(s1(23,8,3));
}
}

