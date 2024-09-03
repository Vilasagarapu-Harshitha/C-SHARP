using System;
interface I1{
void show();
}
class C1:I1{
public void show(){
Console.WriteLine("Hai");
}
}
interface I2:I1{
void show1();
}
class C2:C1,I1{
public void show1(){
Console.WriteLine("Hai1");
}
}
class Harshi15{
static void Main(String[] args){
C1 obj1=new C1();
obj1.show();
C2 obj2=new C2();
obj2.show1();
}
}