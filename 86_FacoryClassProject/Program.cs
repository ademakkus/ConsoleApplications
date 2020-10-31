using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace _86_FacoryClassProject
{
	class Program
	{
		static void Main(string[] args)
		{

			int i, j;
			for (i = 1,j=10; i < 10; i++,j--)
			{
				Rect rect = FactoryClass.FactoryRect(i, j);
				WriteLine(rect.Area().ToString());
				//rect.Enlarge(i);
				//WriteLine(rect.Area().ToString());
			}		
			ReadKey();
		}
	}
}
