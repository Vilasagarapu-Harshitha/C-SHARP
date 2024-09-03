// Stack
/* it contains both generic and non generic. Array list only works with non generic only. stack has user defined methods also so we have to use interface also.
  1.Generic
   2.Non generic
  3.Interface
-> to iterate it we have 
.ienumerable at phase of interface
.iterator
.enumerator
.ForEach
non generic =object=any data type
generic= don't use strings in this.
methods are almost same 
*/
//program
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
class Stack{
public static void Main(String[] args){
Stack<int> s1 = new Stack<int>();
//to insert element into stack 
s1.Push(13);
s1.Push(14);
s1.Push(15);
Console.WriteLine(s1.Peek());
Console.WriteLine(s1.Pop());
Console.WriteLine(s1.Contains(13));
int c=s1.Count;
Console.WriteLine(c);
if(s1.Count==0){
Console.WriteLine("empty");
}
Console.WriteLine(s1);
Stack<int> s2= new Stack<int>(s1);
Console.WriteLine(s2);
foreach(int e1 in s1){
Console.WriteLine(e1);
}
s1.TrimExcess();
Console.WriteLine("After Trim");
var e=s1.GetEnumerator();
while(e.MoveNext()){
Console.WriteLine(e.Current);
}
}
}



 