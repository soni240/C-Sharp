// See https://aka.ms/new-console-template for more information

using System;


namespace PrimeNumber
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int flag = 0;

            for (i = 2; i <= 30; i++)
            {
                j = 2;
                flag = 0;
                while (j <= (i / 2))
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                    j++;
                }

                if (flag == 0)
                    Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
}