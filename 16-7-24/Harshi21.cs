using System;
using System.Threading;

class Harshi21
{
    static void Main()
    {
        Thread character1 = new Thread(Character1Action);
        Thread character2 = new Thread(Character2Action);
        Thread character3 = new Thread(Character3Action);

        character1.Start();
        character2.Start();
        character3.Start();
        character1.Join();
        character2.Join();
        character3.Join();

        Console.WriteLine("All characters have completed their actions.");
    }

    static void Character1Action()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Character 1 is attacking.");
            Thread.Sleep(500);
        }
    }

    static void Character2Action()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Character 2 is defending.");
            Thread.Sleep(700); 
        }
    }

    static void Character3Action()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Character 3 is healing.");
            Thread.Sleep(600);
        }
    }
}
