using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _75_Array_Dynamic
{
	class Program
	{
		static void Main(string[] args)
		{
			ForegroundColor = DarkGreen;
			WriteLine("***** Write Prime Numbers between start and end ***");
			int startNumber, endNumber;
			ForegroundColor = DarkCyan;
			Write("Enter the start number :");
			startNumber = int.Parse(ReadLine());
			ForegroundColor = DarkRed;
			Write("Enter the start number :");
			endNumber = int.Parse(ReadLine());
			ForegroundColor = DarkYellow;
			List<int> primes = GetPrimes(startNumber, endNumber);
			foreach (var item in primes)
			{
				Write("{0} ", item);
			}
			ReadKey();
		}
		static List<int> GetPrimes(int start, int end)
		{
			List<int> primeList = new List<int>();
			for (int num = start; num <= end; num++)
			{
				bool prime = true;
				double numSqrt = Math.Sqrt(num);
				for (int div = 2; div <= numSqrt; div++)
				{
					if (num % div == 0)
					{
						prime = false;
						break;
					}
				}
				if (prime)
				{
					primeList.Add(num);
				}
			}
			return primeList;
		}
	}
}
