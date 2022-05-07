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
            DaysOfWeek.ReadInput();
            Console.ReadLine();

        }
    }
    class Utility
    {
        public static int ReadInput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    }
    class DaysOfWeek
    {

        public static void ReadInput()
        {
            //Get input from Utility Class
            Console.WriteLine("Enter the date(1-30)");
            int d = Utility.ReadInput();
            Console.WriteLine("Enter the month (1-12)");
            int m = Utility.ReadInput();
            Console.WriteLine("Enter the year(yyyy)");
            int y = Utility.ReadInput();
            //Call DayCalculate Function
            DayCalculate(d, m, y);
        }
        private static void DayCalculate(int d, int m, int y)
        {
            //List to print the week
            List<string> day = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            //Given formula: Gregorian calendar
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            //Print day of week 
            Console.WriteLine("Day is :" + day[d0]);
        }


    }
}





