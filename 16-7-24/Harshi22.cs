using System;
using System.Threading;

class Harshi22
{
    static void Main()
    {
        // Create three threads for three runners
        Thread runner1 = new Thread(RunnerAction);
        Thread runner2 = new Thread(RunnerAction);
        Thread runner3 = new Thread(RunnerAction);

        // Start the threads
        runner1.Start("Runner 1");
        runner2.Start("Runner 2");
        runner3.Start("Runner 3");

        // Wait for all threads to complete
        runner1.Join();
        runner2.Join();
        runner3.Join();

        Console.WriteLine("All runners have finished the race.");
    }

    // Action for each runner
    static void RunnerAction(object runnerName)
    {
        string name = (string)runnerName;
        for (int lap = 1; lap <= 5; lap++)
        {
            Console.WriteLine(name+"is running lap"+ lap);
            Thread.Sleep(1000); // Simulate time taken for each lap (1000 milliseconds = 1 second)
            Console.WriteLine(name+" is taking a break after lap "+lap);
            Thread.Sleep(500); // Simulate break time (500 milliseconds = 0.5 seconds)
        }
        Console.WriteLine(name+" has finished the race.");
    }
}
