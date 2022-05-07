// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace Day_6_PracticeProgram
{
    class program
    {
        public static void Main(string[] args)
        {
            NewtonSqrt.ReadInput();
            Console.ReadLine();

        }
    }
    class NewtonSqrt
    {
        public static void ReadInput()
        {
            //Read input from user
            Console.WriteLine("Enter value of c");
            double c = Convert.ToDouble(Console.ReadLine());
            NewtonSquareRoot(c);
        }


        private static void NewtonSquareRoot(double c)
        {
            //Given: local variables
            double t = c;

            //Given l= 1^-5 = 0.00001
            double l = 0.00001;
            double sqrtValue;

            while (true)
            {
                //Compute average of c/t and t
                sqrtValue = 0.5 * (t + (c / t));
                if (Math.Abs(sqrtValue - t) < l)
                {
                    break;
                }
                t = sqrtValue;
            }
            Console.WriteLine("Root Value is :" + Math.Round(sqrtValue, 4));


        }
    }
}


