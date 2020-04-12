using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76_ExtensionMethods
{
	public static class StringExtensions
	{
		public static int WordCount(this string str)
		{

			

			return str.Split(new char[] { ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
		
	}
	}
}
