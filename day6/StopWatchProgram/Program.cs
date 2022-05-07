﻿// See https://aka.ms/new-console-template for more information
using System;

using System.Diagnostics;
class Program
{
    static void Main()
    {
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();

        // Begin timing.
        stopwatch.Start();

        // Do something.
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(1);
        }

        // Stop timing.
        stopwatch.Stop();

        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
    }
}
