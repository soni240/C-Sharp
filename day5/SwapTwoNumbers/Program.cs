// See https://aka.ms/new-console-template for more information
using System;
public class Swap
{ 
   
    
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("before swapping: a=" + a + " b=" + b);
            a = a * b; //a=50(5*10)
            b = a / b; //b=5(50/10) 
            a = a / b; //a=10(50/5)
            Console.WriteLine("after swapping: a =" +a+ " b=" +b);
            Console.ReadKey();
        }
    
}
