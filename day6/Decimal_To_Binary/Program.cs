// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace DecimalToBinary
{
    class program
    {
        public static void Main(string[] args)
        {
            DecimalToBinary.ReadInput();
            Console.ReadLine();

        }
    }
    class DecimalToBinary
    {
        public static void ReadInput()
        {
            //Read input from user
            Console.WriteLine("Enter decimal number");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            DecimalToBinaryConversion(decimalNumber);
        }


        private static void DecimalToBinaryConversion(int decimalNumber)
        {
            //Local variable to iterate
            int count;
            //Store value of binary output
            List<int> binaryNumber = new List<int>();
            for (count = 0; decimalNumber > 0; count++)
            {
                binaryNumber.Add(decimalNumber % 2);
                decimalNumber = decimalNumber / 2;
            }
            //Print BInary Representation
            Console.Write("Binary Representation is =\t");
            for (count = binaryNumber.Count - 1; count > 0; count--)
            {
                Console.Write(binaryNumber[count]);
            }
        }
    }
}





