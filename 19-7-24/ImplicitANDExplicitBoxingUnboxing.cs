/* object type to value type  -> unboxing
value to object -> boxing
ex:
 int i=10;
object o=i; // boxing */

//program:
using System;
class ImplicitANDExplicitBoxingUnboxing{
public static void Main(String[] args){
int i=23;
//boxing
object o = i;
Console.WriteLine(o.GetType());
//unboxing
int y=(int)o; //implicit unboxing
Console.WriteLine(y.GetType());
object x=(object)o; //explicit unboxing
Console.WriteLine(x.GetType());
}
}

//in unboxing explicit is working but not inplicit.
//in boxing implicit is working but not explicit.


