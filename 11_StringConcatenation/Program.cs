using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StringConcatenation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> String concatenation:");
			string s1 = "Programming the ";
			string s2 = "PsychoDrill (PTP)";
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine($"first string :{s1}");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine($"Second string :{s2}");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			string s3 = String.Concat(s1, s2);

			Console.WriteLine("Concatenated strings : "+s3);
			Console.ReadLine();
			Console.WriteLine();
		}
	}
}
