using System;
using System.Threading;

class Harshi23
{
    private static bool _cancel = false;

    static void Main()
    {
        Thread[] workers = new Thread[5];
        for (int i = 0; i < 5; i++)
        {
            string workerName = $"Worker {i + 1}";
            workers[i] = new Thread(() => WorkerTask(workerName));
            workers[i].Name = workerName;
            workers[i].Start();
        }

        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine("Thread Status Report:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker.Name+":"+ worker.ThreadState);
            }
            Thread.Sleep(1000);
        }

        _cancel = true;

        foreach (var worker in workers)
        {
            worker.Join();
        }

 
        Console.Clear();
        Console.WriteLine("Final Thread Status Report:");
        foreach (var worker in workers)
        {
            Console.WriteLine(worker.Name+":"+worker.ThreadState);
        }
    }

    static void WorkerTask(string workerName)
    {
        int taskCount = 0;
        while (!_cancel)
        {
            taskCount++;
            Console.WriteLine(workerName+" is performing task "+taskCount);
            Thread.Sleep(500); 
        }
        Console.WriteLine(workerName+" has been cancelled.");
    }
}

