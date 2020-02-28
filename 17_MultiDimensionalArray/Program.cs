using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_MultiDimensionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Rectangular multidimensional array.");
			// A rectangular MD array.
			int[,] myMatrix;
			myMatrix = new int[3, 10];
			// Populate (3 * 4) array.
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 10; j++)
					myMatrix[i, j] = i * j;
			// Print (3 * 4) array.
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 10; j++)
					Console.Write(myMatrix[i, j] + "\t");
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("=> Implicit Array Initialization.");
			// a is really int[].
			var a = new[] { 1, 10, 100, 1000 };
			Console.WriteLine("a is a: {0}", a.ToString());
			// b is really double[].
			var b = new[] { 1, 1.5, 2, 2.5 };
			Console.WriteLine("b is a: {0}", b.ToString());
			// c is really string[].
			var c = new[] { "hello", null, "world" };
			Console.WriteLine("c is a: {0}", c.ToString());
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
