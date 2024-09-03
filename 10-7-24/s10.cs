using System;

class s11
{
sealed public int a;
public void show(){
Console.WriteLine(a);
}
}
class s10:s11{
public void show(){
int b=2*a;
int c=4+a;
Console.WriteLine(b);
Console.WriteLine(c);
}
static void main(string[] args){
a= Double.parseDouble(args[0]);
s10 s=new s10();
Console.WriteLine(s.a);
Console.WriteLine(s.b);
Console.WriteLine(s.c);
s.show();
}
}


