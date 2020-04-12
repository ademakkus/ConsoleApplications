using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _72_Substring_GetFileNameFromPath
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = "C:\\Pics\\CoolPic.jpg";
			int lastIndex = path.LastIndexOf("\\");
			WriteLine("Last idnex : {0} ", lastIndex);
			int firstIndex = path.IndexOf("\\");
			WriteLine("Last idnex : {0} ", firstIndex);

			string fullName = path.Substring(lastIndex + 1);
			WriteLine("File name : {0}", fullName);

			 fullName = path.Substring(firstIndex + 1);
			WriteLine("File name : {0}", fullName);
			string doc = "Hello, some@gmail.com, " +
"you have been using some@gmail.com in your registration.";
			string fixedDoc =
			doc.Replace("some@gmail.com", "ademakkus@akkus.com");
			Console.WriteLine(fixedDoc);

			string text = "11/12/2001";
			string format = "MM/dd/yyyy";
			DateTime parsedDate = DateTime.ParseExact(
			text, format, CultureInfo.InvariantCulture);
			Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}",
			parsedDate.Day, parsedDate.Month, parsedDate.Year);

			ReadKey();
		}
	}
}
