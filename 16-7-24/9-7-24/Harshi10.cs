using System;

interface I1
{
    void show();
}

class C1
{
    public void show1()
    {
        Console.WriteLine("hai");
    }
}

class C : C1, I1
{
    public void show()
    {
        Console.WriteLine("hello");
    }
}

class Harshi10
{
    static void Main(string[] args)
    {
        C t = new C();
        t.show();
        t.show1();
    }
}