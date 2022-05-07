// See https://aka.ms/new-console-template for more information
using System;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            long fact = 1;
            Console.WriteLine("enter the number= ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of " + num + " is " + fact);
            Console.ReadKey();
        }
    }
}
