// See https://aka.ms/new-console-template for more information
using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if ((n%2) == 0)
                Console.WriteLine(n + "even");
            else
            {
                Console.WriteLine(n + "odd");
                Console.ReadKey();
            }
        }
    }
}
