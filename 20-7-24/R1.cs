//Reflection
/*feature that allows to examine and modify the structure and behaviour of an object at run time(reference).
4 steps:
inspect meta data
create instances
invokes members
modify behaviour
*/

//program
using System;
using System.Reflection;
class R2{
public void M1(string a){
Console.WriteLine(a);
}
}
class R1{
static void Main(string[] args){
Type type=typeof(R2);
MethodInfo info=type.GetMethod("M1");
object ob=Activator.CreateInstance(type);
info.Invoke(ob,new object[]{"Hi hello"});
}
}

