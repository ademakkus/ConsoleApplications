using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _68_Metod_Overloading
{
	class Program
	{
		static void Main(string[] args)
		{
			// Entering the value of the variable n
			ForegroundColor = DarkBlue;
			Console.Write("n = ");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine();
			// Printing the upper part of the triangle
			ForegroundColor = DarkCyan;
			for (int line = 1; line <= n; line++)
			{
				PrintLine(1, line);
			}
			// Printing the bottom part of the triangle
			// that is under the longest line
			WriteLine();
			ForegroundColor = DarkYellow;
			for (int line = n - 1; line >= 1; line--)
			{
				PrintLine(1, line);
			}
			ReadKey();
		}
		static void PrintLine(int start, int end)
		{
			for (int i = start; i <= end; i++)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			
		}
		
		
	}
}
