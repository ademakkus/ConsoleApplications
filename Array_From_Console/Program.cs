using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace Array_From_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkBlue;
			Write("Enter the array boundary :");
			int boundary = Int32.Parse(ReadLine());
			int[] myArray = new int[boundary];
			ForegroundColor = DarkGreen;
			for (int i = 0; i < boundary; i++)
			{
				Write($"Enter the {i+1} value : ");
				myArray[i] = Int32.Parse(ReadLine());
			}
			ForegroundColor = DarkYellow;
			WriteLine("***** My array ***");
			foreach (var item in myArray)
			{
				Write(item + " ");

			}

			ForegroundColor = DarkMagenta;
			bool isSmetric = true;
			for (int i = 0; i < boundary/2; i++)
			{
				if (myArray[i] != myArray[boundary - i - 1])
					isSmetric = false;break;
			}
			WriteLine();
			WriteLine("İs array is smteric ? {0}", isSmetric);
			ReadKey();
		}
	}
}
