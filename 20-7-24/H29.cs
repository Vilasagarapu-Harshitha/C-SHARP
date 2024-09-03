//Deligation
/* creates references for methods is called deligation. creates to hold the method reference variables.it is an object to hold the method references.
syntax:public delegate int sample1(int a,int b);*/

//Program
using System;
class H29{
public delegate void add(int a,int b);
public delegate void sub(int a,int b);
public void sum(int a,int b){
Console.WriteLine(a+b);
}
public void minus(int a,int b){
Console.WriteLine(a-b);
} 
static void Main(string[] args){
H29 h=new H29();
add a1=new add(h.sum);
sub s1=new sub(h.minus);
a1(4,6);
s1(5,2);
}
}




