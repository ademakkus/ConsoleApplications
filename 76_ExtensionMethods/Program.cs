using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			string helloString = "Hello, Extension Methods!, are you sure ?";
			int wordCount = helloString.WordCount();
			Console.WriteLine(wordCount);

			Console.ReadKey();
		}
	}
}
