using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //we have to add this
using System.Threading.Tasks;

namespace _15_StringBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Using the StringBuilder:");
			StringBuilder sb = new StringBuilder("**** Fantastic Games ****"); //using System.Text; don't forget  add this
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			sb.Append("\n");
			sb.AppendLine("Half Life");
			sb.AppendLine("Morrowind");
			sb.AppendLine("Deus Ex" + "2");
			sb.AppendLine("System Shock");
			Console.WriteLine(sb.ToString());
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			sb.Replace("2", " Invisible War");
			Console.WriteLine(sb.ToString());
			Console.WriteLine("sb has {0} chars.", sb.Length); //string is char array
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
