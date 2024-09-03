//tostring and toarray
/* */
using System;
using System.Collections.Generic;
class tsta{
static void Main(String[] args){
Queue<int> q1=new Queue<int>();
q1.Enqueue(12);
q1.Enqueue(13);
q1.Enqueue(14);
q1.Enqueue(15);
int[] a1=q1.ToArray();
foreach(int i in a1){
Console.WriteLine(i);
}
string[] s1=q1.ToString().Split(',');
foreach(string i in s1){
Console.WriteLine(i.GetType());
}
}
}