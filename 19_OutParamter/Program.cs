using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //with c#6 
using static System.ConsoleColor;
namespace _19_OutParamter
/*
 . Output parameters do not need to be initialized before they are passed to the method
 .Starting with C# 7, out parameters do not need to be declared before using them. In other words, they can be declared inside the method call
*/
{
	class Program
	{
		// Output parameters must be assigned by the called method.
		static void Add(int x, int y, out int ans)
		{
			ans = x + y;
		}
		static void Main(string[] args)
		{
			WriteLine("****** Using out keyword with parameters *****");
			Add(90, 90, out int ans);
			Console.WriteLine("90 + 90 = {0}", ans);


			ReadKey();
		}
	}
}
