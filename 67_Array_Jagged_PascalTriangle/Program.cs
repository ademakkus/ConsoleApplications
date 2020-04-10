using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _67_Array_Jagged_PascalTriangle
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkBlue;

			Write("Enter the pascal tirangle height :");
			int height = int.Parse(ReadLine());
			long[][] triangle = new long[height + 1][];
			for (int row = 0; row < height; row++)
			{
				triangle[row] = new long[row + 1];
			}
			//calculate the Pascal's triangle
			triangle[0][0] = 1;
			for (int row = 0; row < height - 1; row++)
			{
				for (int col = 0; col <= row; col++)
				{
					triangle[row + 1][col] += triangle[row][col];
					triangle[row + 1][col + 1] += triangle[row][col];
				}
			}
			// Print the Pascal's triangle
			for (int row = 0; row < height; row++)
			{
				Write("".PadLeft((height - row) * 2));
				for (int col = 0; col <= row; col++)
				{
					Write("{0,3}", triangle[row][col]);
				}
				WriteLine();

			}
			ReadKey();
		}
	}
}
