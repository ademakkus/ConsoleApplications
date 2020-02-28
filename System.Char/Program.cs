using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Char
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("=> char type Functionality:");
			Console.WriteLine();
			char myChar = 'a';
			Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
				
			char.IsWhiteSpace("Hello There", 5));
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
			char.IsWhiteSpace("Hello There", 6));
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("char.IsPunctuation('?'): {0}",
			char.IsPunctuation('?'));
			Console.WriteLine();
			Console.ReadKey();

		}
	}
}
