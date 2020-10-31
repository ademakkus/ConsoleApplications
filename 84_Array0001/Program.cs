using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _84_Array0001
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = new[] {1, 12, 3, -4, 23, 5, 123};
			WriteLine($"{"Index"}{"Value",8}"); ///for columns headings

			for (int counter = 0; counter < array.Length; counter++)
			{
				WriteLine($"{counter,5}{array[counter],8}");
			}
			ReadKey();

		}
	}
}
