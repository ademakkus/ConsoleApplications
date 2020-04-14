using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _81_WordsCounter
{
	class Program
	{
		static void Main(string[] args)
		{

			string text = ReadText();
			string[] words = ExtractWords(text);
			CountWords(words);
			TestExtractSeparators();
			ReadKey();
		}

		public  static string ReadText()
		{
			Write("Enter text : ");
			return ReadLine();
		}

		private static char[] ExtractSeperators(string text)
		{
			HashSet<char> seperators = new HashSet<char>();
			foreach (char character in text)
			{

				if(!char.IsLetter(character))
				{
					seperators.Add(character);
				}
			}
			return seperators.ToArray();

		}

		private static string[] ExtractWords(string text)
		{

			char[] seperators = ExtractSeperators(text);
			string[] words = text.Split(seperators,
			StringSplitOptions.RemoveEmptyEntries);
			return words;
		}
		private static bool IsUpperCase(string word)
		{

			bool result = word.Equals(word.ToUpper());
			return result;
		}
		private static bool IsLowerCase(string word)
		{

			bool result = word.Equals(word.ToLower());
			return result;
		}

		private static void CountWords(string[] words)
		{
			int allUpperCaseWordsCount = 0;
			int allLowerCaseWordsCount = 0;
			foreach (string word in words)
			{
				if (IsUpperCase(word))
				{
					allUpperCaseWordsCount++;
				}
				else if(IsLowerCase(word))
				{
					allLowerCaseWordsCount++;
				}
			}
			ForegroundColor = DarkBlue;
			WriteLine("Total words count : {0}", words.Length);
			//WriteLine($"Total words count : {words.Length}");
			ForegroundColor = DarkGreen;
			WriteLine($"Upper case words count {allUpperCaseWordsCount}");

			ForegroundColor = DarkYellow;
			WriteLine($"Lower case words count {allLowerCaseWordsCount}");
			//Clear();
			ResetColor();
			WriteLine("new line**************");
			//ReadKey();
		}

		private static List<string> GetTestData()
		{
			List<string> testData = new List<string>();
			testData.Add("This is wonderful !!! All seperators like" + " these ,.(? and these /* are recognized . It works .");
			testData.Add("SingleWord");
			testData.Add(string.Empty);
			testData.Add(">?!?#@?");
			return testData;
		}
		private static void TestExtractSeparators()
		{
			List<string> testData = GetTestData();
			foreach (string testCase in testData)

			{
				Console.WriteLine(
				"Test Case:{0}{1}", Environment.NewLine, testCase);
				Console.WriteLine("Result:");
				foreach (char separator in ExtractSeperators(testCase))
				{
					Console.Write("{0} ", separator);
				}
				Console.WriteLine();
			}
		}

	}
}
