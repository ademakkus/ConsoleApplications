using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_VerbatimString
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(@"C:\MyApp\bin\Debug");
			Console.ForegroundColor = ConsoleColor.DarkMagenta;
			//before verbatim string 
			string myLongString ="This is a very very 		" +
				"	very  long " +
		"string";
		
			Console.WriteLine("Before verbatim : "+myLongString);
			//after verbatim string 
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			string myLongStringLit = @"This is a very
very
			very
long string";
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.Write("After verbatim :");
			Console.WriteLine(myLongStringLit);
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
			Console.ReadKey();
		}
	}
}
