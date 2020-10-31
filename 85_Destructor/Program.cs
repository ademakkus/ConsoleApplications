using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static  System.Console;
namespace _85_Destructor
{

	public class DestructSample
	{
		public int X;

		public DestructSample(int i)
		{
			X = i;
		}

		~DestructSample()
		{

			WriteLine("Destructing "+X);
		}

		public void Generator(int i)
		{
			DestructSample destructSample=new DestructSample(i);
		}
	}
	static class Program
	{
		static void Main(string[] args)
		{
			var sw=new Stopwatch();
			
			DestructSample obj=new  DestructSample(0);

			for (int i = 1; i < 100000; i++)
			{
				obj.Generator(i);
				
				
			}
			WriteLine("Done.");
			ReadKey();
		}
	}
}
