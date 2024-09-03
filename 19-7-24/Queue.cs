//Queue
/* queue has */
//program
using System;
using System.Collections.Generic;
class Queue{
Static void Main(String[] args){
Queue<int> q1=new Queue<int>();
q1.Enqueue(13);
q1.Enqueue(14);
q1.Enqueue(15);
q1.Enqueue(16);
q1.Enqueue(17);
foreach(int y in q1){
Console.WriteLine(q1.Dequeue());
}
}
}

