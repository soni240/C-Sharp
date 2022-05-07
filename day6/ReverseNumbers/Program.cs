// See https://aka.ms/new-console-template for more information
using System;

namespace system
{
	class reverse
	{
		static void Main(String[] args)
		{
			int a = 721, rev = 0, b;

			
			while (a != 0)
			{
				b = a % 10;        
				rev = (rev * 10) + b;   
				a = a / 10;             
			}
			Console.WriteLine("The reverse of the number is: " + rev);
		}
	}
}
