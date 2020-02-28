using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
/*
 •	 Reference parameters must be initialized before they are passed to the method.
The reason for this is that you are passing a reference to an existing variable. If you
don’t assign it to an initial value, that would be the equivalent of operating on an
unassigned local variable.
	 */
namespace _21_RefKeyword
{
	class Program
	{
		// Reference parameters.
		public static void SwapStrings(ref string s1, ref string s2)
		{
			string tempStr = s1;
			s1 = s2;
			s2 = tempStr;
		}
		static void Main(string[] args)
		{
			string str1 = "Flip";
			string str2 = "Flop";
			Console.WriteLine("Before: {0}, {1} ", str1, str2);
			SwapStrings(ref str1, ref str2);
			Console.WriteLine("After: {0}, {1} ", str1, str2);
			Console.ReadLine();
			ReadKey();
		}
	}
}
