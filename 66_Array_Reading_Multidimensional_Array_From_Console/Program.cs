using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_Array_Reading_Multidimensional_Array_From_Console
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.Write("Enter the number of the rows: ");
			int rows = int.Parse(Console.ReadLine());

			Console.Write("Enter the number of the columns: ");
			int cols = int.Parse(Console.ReadLine());

			int[,] matrix = new int[rows, cols];

			Console.WriteLine("Enter the cells of the matrix:");
			Console.ForegroundColor = ConsoleColor.DarkYellow;

			for (int row = 0; row < rows; row++)
			{
				for (int col = 0; col < cols; col++)
				{
					Console.Write("matrix[{0},{1}] = ", row, col);
					matrix[row, col] = int.Parse(Console.ReadLine());
				}
			}

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			for (int row = 0; row < matrix.GetLength(0); row++) //get length of first dimension
			{
				for (int col = 0; col < matrix.GetLength(1); col++) //get length of second dimension
					//for (int col = 0; col < matrix.GetLength(2); col++)//get length of third dimension 
					{
					Console.Write(" " + matrix[row, col]);
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
