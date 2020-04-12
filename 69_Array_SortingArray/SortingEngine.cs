using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _69_Array_SortingArray
{
	public class SortingEngine
	{

		/// <summary>
		/// Sort an int array
		/// </summary>
		/// <param name="numbers">int[] array params</param>
		/// <returns>int[] array</returns>
		public static int[] Sort(params int[] numbers)
		{
			for (int i = 0; i < numbers.Length-1; i++)
			{
				for (int j = i+1; j < numbers.Length; j++)
				{
					if (numbers[i]>numbers[j])
					{
						int oldNumber = numbers[i];
						numbers[i] = numbers[j];
						numbers[j] = oldNumber;
					}
				}
			}
			return numbers;
		}
	public	static void PrintNumbers(params int[] numbers)
		{
			ForegroundColor = DarkGreen;
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write("{0} ", numbers[i]);
				if (i<numbers.Length-1)
				{
					Console.Write(",");
				}

			}
		}
	}
}
