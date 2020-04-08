using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_Write_PrimeNumber_Range_N_M
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Find and Write Prime Number Range N and M");
			Console.Write("Type start N number  = ");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Type end M number  = ");
			int m = int.Parse(Console.ReadLine());
			for (int num = n; num <= m; num++)
			{
				bool prime = true;
				int divider = 2;
				int maxDivider = (int)Math.Sqrt(num);
				while (divider <= maxDivider)
				{
					if (num % divider == 0)
					{
						prime = false;
						break;
					}
					divider++;
				}
				if (prime)
				{
					Console.Write(" " + num);
				}
			}
		
			Console.ReadKey();
		}
	}
}
