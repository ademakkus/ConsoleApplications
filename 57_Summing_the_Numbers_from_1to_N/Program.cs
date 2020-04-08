using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _57_Summing_the_Numbers_from_1to_N
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 1;
			int sum = 1;
			Write("Enter N number : ");
			int numberN = int.Parse(ReadLine());
			ForegroundColor = DarkYellow;
			Write("The sum 1");
			while (num<numberN)
			{
				num++;
				sum += num;
				Write(" + " + num);
				if (num % 10 == 0)
					WriteLine();
			}
			ForegroundColor = DarkGreen;
			WriteLine("=" + sum);
			
			
			ReadKey();
		}
	}
}
