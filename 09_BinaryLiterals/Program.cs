using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BinaryLiterals
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("=> Use Binary Literals:");
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Sixteen: {0}", 0b0001_0000); //in 0b0001_0000 b is binary
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("Thirty Two: {0}", 0b0010_0000);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Sixty Four: {0}", 0b0100_0000);
			Console.ReadKey();
		}
	}
}
