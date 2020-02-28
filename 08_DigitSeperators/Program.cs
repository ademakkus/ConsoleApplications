using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DigitSeperators
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Use Digit Separators:");
			Console.Write("Integer:");
			Console.WriteLine(123_456);
			Console.Write("Long:");
			Console.WriteLine(123_456_789L);
			Console.Write("Float:");
			Console.WriteLine(123_456.1234F);
			Console.Write("Double:");
			Console.WriteLine(123_456.12);
			Console.Write("Decimal:");
			Console.WriteLine(123_456.12M);
			Console.ReadKey();
		}
	}
}
