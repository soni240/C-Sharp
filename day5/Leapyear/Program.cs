// See https://aka.ms/new-console-template for more information
int year;
Console.WriteLine("enter the year:");
year = int.Parse(Console.ReadLine());
if (year % 4 == 0 && year % 400 == 0)
{
    Console.WriteLine(year + "is a leap year:");

}
else
{
    Console.WriteLine(year + "is a not leap year:");

}

