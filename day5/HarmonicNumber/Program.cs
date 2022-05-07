// See https://aka.ms/new-console-template for more information
using System;
public class Harmonic
{
    public static void Main(string[] args)
    {
        int i, n;
        double   s=0.0;
            Console.Write("\n\n");
        Console.Write("calculate the harmonic series and their sum\n");
        Console.Write("----------");
        Console.Write("\n\n");
        Console.Write("input the no of terms : ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n\n");
        for (i = 1; i <= n; i++)
        {
            Console.WriteLine("1/{0}+", i);
            s+=1/(float)i;
        }
        Console.Write("\nsum of series upto {0} terms :{1} \n",n,s);
    }
}
