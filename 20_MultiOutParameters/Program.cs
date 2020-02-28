using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ConsoleColor;
using static System.Console;
namespace _20_MultiOutParameters
{
	class Program
	{
		// Returning multiple output parameters. we can do this with tuples
		static void FillTheseValues(out int a, out string b, out bool c)
		{
			a = 9;
			b = "Enjoy your string.";
			c = true;
			ForegroundColor = DarkGray;
			WriteLine("*** In FillTheseValues method print values ****** ");
			Console.WriteLine("Int is: {0}", a);
			Console.WriteLine("String is: {0}", b);
			Console.WriteLine("Boolean is: {0}", c);
			WriteLine();
		}
		static void Main(string[] args)
		{
			
			int i; string str; bool b;
			FillTheseValues(out i, out str, out b);
			ForegroundColor = DarkGreen;
			WriteLine("*** In Main method print values ****** ");
			ForegroundColor = DarkYellow;
			Console.WriteLine("Int is: {0}", i);
			WriteLine();
			//ForegroundColor = DarkMagenta;
			Console.WriteLine("String is: {0}", str);
			WriteLine();
			//ForegroundColor = DarkGreen;
			Console.WriteLine("Boolean is: {0}", b);
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
