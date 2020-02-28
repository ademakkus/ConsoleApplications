using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _23_ParamsParameter_2
{
	class Program
	{
		static double CalculateAverage(params int[] values)
		{
			ForegroundColor = DarkBlue;
			Console.WriteLine("You sent me {0} integers.", values.Length);
			double sum = 0;
			if (values.Length == 0)
				return sum;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];
			return (sum / values.Length);
		}
		static void Main(string[] args)
		{
			int[] myInts = new int[20];

			Random random = new Random();
			for (int i = 0; i < 20; i++)
			{
				myInts[i] = random.Next(100,1000);
			}
			WriteLine();
			ForegroundColor = DarkGreen;
			double average = CalculateAverage(myInts);
			WriteLine(" Average of data is: {0}", average);
			ReadKey();
		}
	}
}
