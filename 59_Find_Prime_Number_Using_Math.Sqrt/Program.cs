using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _59_Find_Prime_Number_Using_Math.Sqrt
{
	/*
	 * int divider = 2;
int maxDivider = (int)Math.Sqrt(num);
bool prime = true;
while (prime && (divider <= maxDivider))
{
if (num % divider == 0)
{
prime = false;
}
divider++;
}
Console.WriteLine("Prime? " + prime);
	 * */
	class Program
	{
		static void Main(string[] args)
		{
			Write("Enter a number :");
			int number = int.Parse(ReadLine());
			int divider = 2;
			int maxDivider = (int)Math.Sqrt(number);
			bool isPrime = true;
			while (isPrime &&(divider<=maxDivider))
			{
				if (number % divider == 0)
					isPrime = false;
				else
					divider++;
			}
			Console.WriteLine("Prime? :" + isPrime);
			WriteLine("{0} is Prime : {1}",number,isPrime ? " prime" : "Not Prime");
			ReadKey();

		}
	}
}
