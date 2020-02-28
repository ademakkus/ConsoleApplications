using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_StringEquality
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> String equality:");
			string s1 = "Hello!";
			string s2 = "Yo!";
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			Console.WriteLine("s1 = {0}", s1);
			Console.WriteLine("s2 = {0}", s2);
			Console.WriteLine();
			// Test these strings for equality.
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("s1 == s2: {0}", s1 == s2);
			Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
			Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
			Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine();
			Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
			Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
