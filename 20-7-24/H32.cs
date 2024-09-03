//anonymous delegation
/*this provides a technique to pass a code block as a delegate parameter .Anonymous methods are the methods without name ,just with body.*/

//program
using System;
delegate void change(int n);
class H32{
static int num =12;
public static void add(int p){
num+=p;
Console.WriteLine(num);
}
public static void sub(int x){
num-=x;
Console.WriteLine(num);
}
static void Main(string[] args){
change n=delegate(int a){
Console.WriteLine(a);
};
n=new change(add);
n(34);
n=new change(sub);
n(3);
Console.ReadKey();
}
}