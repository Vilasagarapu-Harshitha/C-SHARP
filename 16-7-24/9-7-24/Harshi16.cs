using System;
interface I1{
void show1();
}
class c1:I1{
public void show1(){
Console.WriteLine("Class1 interface1");
}
}
interface I2{
void show2();
}
class c2:I1{
public void show3(){
Console.WriteLine("Class2 interface1");
}
}
class c:c1,I2,c2{
public void show2(){
Console.WriteLine("Class interface2");
}
}
class Task9{
static void Main(String[] args){
c1 o1=new c1();
o1.show1();
c2 o2=new c2();
o2.show3();
c o=new c();
o.show2();
}
}