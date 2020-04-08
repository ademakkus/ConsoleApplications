using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _58_Find_Prime_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isPrime = true;
			Write("Enter a number : ");
			int number = int.Parse(ReadLine());
			ForegroundColor = DarkYellow;

			for (int i = 2; i < number; i++)
			{
				if (number % i == 0)
				{
					isPrime = false;
					break;
				}
				else
				{
					isPrime = true;
				}

			}
		
			if (isPrime)
			{
				ForegroundColor = DarkRed;
				WriteLine($"{number} is Prime");
			}
			else
			{
				ForegroundColor = DarkGreen;
				WriteLine($"{number} is NOT Prime");
			}

			ReadKey();
		}
	}
}
