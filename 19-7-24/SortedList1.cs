//Sorted list dictionary is slow so we use this.
/* stores in key value if it is generic then we have to give type for both key and value
key unique and  value may be duplicate or not but not key.
Add(),clear(),contains(),remove(),indexOf()...... are methods in it. 
if key is null it doesnt allow it throw runtime error */
//Program
using System;
using System.Collections.Generic;
class Sortedlist1{
public static void Main(String[] args){
SortedList<int,string> s1=new SortedList<int,string>();
s1.Add(12, "a");
s1.Add(13, "b");
s1.Add(14, "c");
s1.Add(15, "d");
foreach(KeyValuePair<int,string> x in s1){
Console.WriteLine(x);
}
}
}
