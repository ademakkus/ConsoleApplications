using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ConsoleColor;
using static System.Console;
namespace _70_Recursive_Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkRed;
			Write("Enter a number :");
			int n = int.Parse(ReadLine());
			decimal result = Factorial(n);
			ForegroundColor = DarkGreen;
			WriteLine("Recursive method calling.Factorial {0} is : {1}", n, result);

			//
			ForegroundColor = DarkMagenta;
			Write("Enter a n2 number :");
			decimal n2 = int.Parse(ReadLine());
			decimal resultn2 = Factorial2(n2);
			ForegroundColor = DarkGreen;
			WriteLine("İterative method calling. Factorial {0} is : {1}", n2, resultn2);

			ReadKey();
		}
		/// <summary>
		/// Using recursive method count factorial
		/// </summary>
		static decimal Factorial(int n)
		{
			ForegroundColor = DarkYellow;
		
			if (n == 0)
				return 1;
			else
				return n * Factorial(n - 1);
			
		}
		static decimal Factorial2(decimal n)
		{
			ForegroundColor = DarkRed;
			WriteLine("Using iterative method");
			int result = 1;
			for (int i = 0; i < n; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}
/*
 * directly recursive : When in the body of a method there is a call to the same method, we say that
the method is directly recursive.

indirectly recursive or mutually recursive: If method A calls method B, method B calls method C, and method C calls
method A we call the methods A, B and C indirectly recursive or mutually
recursive.
 * */
