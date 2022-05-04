int n;

Console.WriteLine("enter the power of 2: ");
n = int.Parse(Console.ReadLine());
if(n>30)
{
    Console.WriteLine("\nInt datatype range exceeds..!!\nNote: please enter powers of 2 less than 31 ");
    Environment.Exit(0);

}
for(int i = 1; i <= n; i++)
{
    double result = 0;
    result = Math.Pow((2), i); // finding power of 2 for current iteration of 1
    Console.WriteLine("2 to the power " + i + " is = " + result);
}