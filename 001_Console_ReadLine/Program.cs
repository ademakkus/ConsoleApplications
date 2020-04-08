using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Console_ReadLine
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write("Enter a number :");
			string str = Console.ReadLine();
			bool parseSuccess = Int32.TryParse(str, out int intValue);
			Console.WriteLine(parseSuccess ?
			"The square of the number is " + intValue * intValue + "."
			: "Invalid number!");
			Console.ForegroundColor = ConsoleColor.DarkRed;
			ConsoleKeyInfo key = Console.ReadKey();
			Console.WriteLine();
			
				
			Console.WriteLine("Character entered: " + key.KeyChar); //pressed key
			Console.WriteLine("Special keys: " + key.Modifiers); //along with information about the keys [Shift], [Ctrl] 		and[Alt]
 Console.ReadKey();
		}
	}
}
