using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_StringLiteralEscapers
{
	class Program
	{
		static void Main(string[] args)
		{

			/*
			 * \' Inserts a single quote into a string literal.
\" Inserts a double quote into a string literal.
\\ Inserts a backslash into a string literal. This can be quite helpful when defining file or
network paths.
\a Triggers a system alert (beep). For console programs, this can be an audio clue to the user.
\n Inserts a new line (on Windows platforms).
\r Inserts a carriage return.
\t Inserts a horizontal tab into the string literal.
			 * */

			Console.WriteLine("=> Escape characters:\a");
			string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
			Console.WriteLine(strWithTabs);
			Console.WriteLine("Everyone loves \"Hello World\"\a ");
			Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
			// Adds a total of 4 blank lines (then beep again!).
			Console.WriteLine("All finished.\n\n\n\a ");
			Console.ReadKey();
			Console.WriteLine();
		}
	}
}
