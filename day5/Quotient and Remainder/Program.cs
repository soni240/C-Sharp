// See https://aka.ms/new-console-template for more information
using System;
namespace QuoientReminder
{
    class Program
    {
       static void Main(string[] args)
        {
            int a = 17, b = 5;
            int q, r;
            q = a / b;
            r = a % b;
            Console.WriteLine("when "+a+"is divided by "+b+", quotient is "+q+" and remainder is "+r+". ");
            Console.ReadKey();
        }
    }
}
