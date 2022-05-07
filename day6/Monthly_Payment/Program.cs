// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace qus1
{
    class Program
    {


        static void Main(string[] args, double lone)
        {
            double loan = 0.0;
            int NOY = 0;
            double paid_monthly_rate = 0.01;
            int paid_annual_rate = 0;
            double payment = 0.0;

            Console.Out.Write("enter the annual intrast rate : ");
            paid_annual_rate = Convert.ToInt32(Console.ReadLine());
            Console.Out.Write("\n enter the number of monthly payments : ");
            NOY = Convert.ToInt32(Console.ReadLine());

            Console.Out.Write("\n enter loan amount : ");
            lone = Convert.ToDouble(Console.ReadLine());

            Console.Out.Write("\n ***********************   Result   *******************  ");


            Console.Out.Write("\n Lone Ammount : " + loan);
            //paid_monthly_rate = Convert.ToDouble((1/100));
            Console.Out.Write("\n Monthly intrast rate : " + paid_monthly_rate);
            Console.Out.Write("\n Number of Monthly instalment : " + NOY);
            double val = Convert.ToDouble(Math.Pow((1 + paid_monthly_rate), NOY));
            payment = Convert.ToDouble((paid_monthly_rate * val * lone) / (val - 1));


            Console.Out.Write("\n Ammount paid back : " + payment * NOY);
            Console.Out.Write("\n Intrast Ammount : " + ((payment * NOY) - loan));
            Console.Out.Write("\n Monthly Payment : " + (payment));



            Console.Read();
        }
    }
}