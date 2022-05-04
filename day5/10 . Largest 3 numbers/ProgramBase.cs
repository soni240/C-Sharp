// See https://aka.ms/new-console-template for more information
namespace Largest;

internal class ProgramBase
{
    static void Main(string[] args)

    {
        int x, y, z;
        string[] numbers;
        Console.WriteLine("enter the three numbers = ");
        numbers = Console.ReadLine().Split();
        x = int.Parse(numbers[0]);
        y = int.Parse(numbers[1]);
        z = int.Parse(numbers[2]);
        if (x >= y)
        {
            if (x >= z)
                Console.WriteLine(x + " the largest number ");
            else
                Console.WriteLine(z + " the largest number ");
        }
        else
        {
            if (y >= z)
                Console.WriteLine(y + " the largest number ");
            else
                Console.WriteLine(z + " the largest number ");
        }
        Console.ReadKey();
    }
}
