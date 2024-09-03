using System;

interface I1
{
    void show1();
}

class C1 :I1
{
    public void show1()
    {
        Console.WriteLine("hai");
    }
}
class C2:I1{
public void show1(){
         Console.WriteLine("h");
    }
}

class C : C1
{
    public void show()
    {
        Console.WriteLine("hello");
    }
}

class Harshi11
{
    static void Main(string[] args)
    {
        C t = new C();
        t.show();
        C1 t1 = new C1();
        t1.show1();
        C2 t2 = new C2();
        t2.show1();
    }
}