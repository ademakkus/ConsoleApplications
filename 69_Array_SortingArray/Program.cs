using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _69_Array_SortingArray
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = SortingEngine.Sort(10, 3, 5, -1, 0, 12, 8);
			SortingEngine.PrintNumbers(numbers);

		
			ReadKey();
		}
	}
}
