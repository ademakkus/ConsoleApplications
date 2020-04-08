using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Write_Args_Parameters
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			for (int i = 0; i < args.Length; i++)
			{
				Console.WriteLine($"args[{i}] : {args[i]}");
			}
			Console.WriteLine(a);
			Console.ReadKey();
		}
	}
}
