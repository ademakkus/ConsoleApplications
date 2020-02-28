using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //with c#6 
using static System.ConsoleColor;

namespace _18_DeafaultValueParameters
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkBlue;
			Console.WriteLine("***** Default Value Pass *****\n");
			// Pass two variables in by value.
			int x = 9, y = 10;
			ForegroundColor = DarkMagenta;
			Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
			Console.WriteLine("Answer is: {0}", Add(x, y));
			Console.WriteLine();
			ForegroundColor = DarkYellow;
			Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
			Console.ReadLine();
			Console.ReadKey();
		}
		// Arguments are passed by value by default.
		static int Add(int x, int y)
		{
			int ans = x + y;
			// Caller method will not see these changes at x and y variables new values  .
			// as we are modifying a copy of the  original data.
			x = 10000;
			y = 88888;
			return ans;
		}
	}
}
