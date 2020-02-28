using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_ParamsParameter
{
	class Program
	{
		// Return average of "some number" of doubles.
		static double CalculateAverage(params double[] values)
		{
			Console.WriteLine("You sent me {0} doubles.", values.Length);
			double sum = 0;
			if (values.Length == 0)
				return sum;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];
			return (sum / values.Length);
		}
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			double average;
			average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
			Console.WriteLine("Average of data is: {0}", average);

			Console.ReadKey();
		}
	}
}
