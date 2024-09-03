using System;
interface I{
void show();
}
interface I1:I
{
void show1();
}
interface I2:I
{
void show2();
}
interface I3:I
{
void show3();
}
class C:I1,I2,I3{
public void show(){
Console.WriteLine("Hai");
}
public void show1(){
Console.WriteLine("Hai1");
}
public void show2(){
Console.WriteLine("Hai2");
}
public void show3(){
Console.WriteLine("Hai3");
}
}
class Harshi131{
static void Main(String[] args){
C obj=new C();
obj.show();
obj.show1();
obj.show2();
obj.show3();
}
}