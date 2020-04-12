using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _74_Stream_Read_CountingWordOccurrences
{
	class Program
	{
		static void Main(string[] args)
		{
			string fileName = @"..\..\sample.txt";
			string word = "C#";
			try
			{
				StreamReader reader = new StreamReader(fileName);
				using (reader)
				{
					int occurrences = 0;
					string line = reader.ReadLine();
					while (line!=null)
					{
						int index = line.IndexOf(word);
						while (index!=-1)
						{
							occurrences++;
							index = line.IndexOf(word, (index + 1));
						}
						line = reader.ReadLine();
					}
					WriteLine("The word {0} occurs {1} times", word, occurrences);
				}

			}
			catch (FileNotFoundException)
			{

				WriteLine("Can not find file {0}", fileName);
			}
			catch (IOException)
			{

				Error.WriteLine("Can read file {0}", fileName);
			}
		
			
			ReadKey();
		}
	}
}
