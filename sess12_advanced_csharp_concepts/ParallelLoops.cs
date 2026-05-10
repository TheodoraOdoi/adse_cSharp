using System;
using System.Threading;
using System.Threading.Tasks; // Required for Parallel.For

namespace sess12_advanced_csharp_concepts;

/// <summary>
/// Program to demonstrate the Parallel.for() loop in comparison with a normal for loop
/// </summary>
public class ParallelLoops
{
    static void Main(string[] args)
    {
        Console.WriteLine("Displaying the first ten numbers using a normal for loop: " +
                          "\n" + new string('-', 40));

        for (int n = 1; n <= 10; n++)
        {
            Console.WriteLine($"{n:00} executed by thread with id " +
                              $"{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(100); // Put the thread to sleep to simulate some processing
        }

        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Displaying the first ten numbers using a parallel for loop: " +
                          "\n" + new string('-', 40));

        // Added the missing '{' here to define the body of the lambda!
        // Also, remember that '10' here means it will stop at 9. Change to '11' if you want 1-10!
        Parallel.For(1, 10, n =>
        {
            Console.WriteLine($"{n:00} executed by thread with id " +
                              $"{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(100); // Put the thread to sleep to simulate some processing
        });
    }
}