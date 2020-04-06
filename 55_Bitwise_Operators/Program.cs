using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Bitwise_Operators
{
	class Program
	{
		static void Main(string[] args)
		{
			byte a = 3; // 0000 0011 = 3
			byte b = 5; // 0000 0101 = 5
			Console.WriteLine(a | b); // 0000 0111 = 7
			Console.WriteLine(a & b); // 0000 0001 = 1
			Console.WriteLine(a ^ b); // 0000 0110 = 6
			Console.WriteLine(~a & b); // 0000 0100 = 4
			Console.WriteLine(a << 1); // 0000 0110 = 6
			Console.WriteLine(a << 2); // 0000 1100 = 12
			Console.WriteLine(a >> 1); // 0000 0001 = 1
			Console.ReadKey();
		}
	}
}
