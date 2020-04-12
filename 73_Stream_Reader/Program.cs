using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _73_Stream_Reader
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter streamWriter = new StreamWriter("number.txt");
			
				for (int i = 0; i < 100; i++)
				{
					streamWriter.Write(i);
				}
			streamWriter.Close();
			StreamReader streamReader = new StreamReader("number.txt");
			string line = streamReader.ReadLine();
			while (line!=null)
			{
				line = streamReader.ReadLine();
			}
			WriteLine(line);
			ReadKey();
			}
		}
	}

