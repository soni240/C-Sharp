// See https://aka.ms/new-console-template for more information
using System;
namespace VowelConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("enter the character: ");
            x = Console.ReadLine()[0];
            if ((x >= 65 && x <= 90 ) || (x >= 97 && x <= 122))
                    {
                if (x == 'A' || x == 'a' || x == 'E' || x == 'e' || x == 'I' || (x == 'i' || x == 'O' || x == 'o' || x == 'U' || x == 'u'))
                    Console.WriteLine(x + "is a vowel");
                else
                    Console.WriteLine(x + "is a consonant");
            }
            else
                Console.WriteLine(x + "is neighter a vowel nor a consonant");
            Console.ReadKey();
        }

    }
}
