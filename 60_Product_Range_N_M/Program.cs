using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _60_Product_Range_N_M
{
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger product = 1;
			ForegroundColor = DarkBlue;
			int n, m,num;

			Write("Enter N number : ");
			n = int.Parse(ReadLine());
			ForegroundColor = DarkRed;
			Write("Enter M number : ");
			m = int.Parse(ReadLine());
			//num = n < m ? n : m;
			if (n<m)
			{
				do
				{
					product *= n;
					n++;
				
				} while (n<=m);
				
			}
			else
			{
				do
				{
					product *= m;
					m++;
					
				} while (m <= n);
				
			}
			WriteLine();
			ForegroundColor = DarkYellow;
			WriteLine(String.Format("product[n...m] = {0:0.00}" ,product));
			ReadKey();
		}
	}
}
