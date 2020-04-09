using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _64_Array_Reverse
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myArray = { 1, 10, -13, 54, 32, 9, 0, 324, 1000 };
			int length = myArray.Length;
			ForegroundColor = DarkBlue;
			WriteLine("First element of array :"+myArray.FirstOrDefault());
			WriteLine("Last  element of array :" + myArray.LastOrDefault());
			WriteLine();
			ForegroundColor = DarkCyan;
			int[] reverseArray = new int[length];
			for (int i = 0; i < length; i++)
			{
				reverseArray[length - i-1] = myArray[i];
				
			}
			WriteLine();
			ForegroundColor = DarkGreen;
			WriteLine("***** Reversed Array ******");
			for (int index = 0; index < length; index++)
			{
				Write(reverseArray[index]+"  ");
			}

			ReadKey();
		}
	}
}
