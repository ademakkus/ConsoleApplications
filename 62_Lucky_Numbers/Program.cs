using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _62_Lucky_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkRed;
			WriteLine("\n**** LUCKY NUMBERS ***\n");
			ForegroundColor = DarkGreen;
			for (int a = 0; a < 10; a++)
			{
				for (int b = 0; b < 10; b++)
				{
					for (int c = 0; c < 10; c++)
					{
						for (int d = 0; d < 10; d++)
						{
							if ((a+b)==(c+d))
							{
								WriteLine(" " + a + " " + b+" " + " : " + c + " " + d);
							}
						}
					}
				}
			}

			ReadKey();
		}
	}
}
