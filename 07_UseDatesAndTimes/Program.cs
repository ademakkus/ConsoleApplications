using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_UseDatesAndTimes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Dates and Times:");
			// This constructor takes (year, month, day).
			DateTime dt = new DateTime(2015, 10, 17);
			// What day of the month is this?
			Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
			// Month is now December.
			dt = dt.AddMonths(2);
			Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
			// This constructor takes (hours, minutes, seconds).
			TimeSpan ts = new TimeSpan(4, 30, 0);
			Console.WriteLine(ts);
			// Subtract 15 minutes from the current TimeSpan and
			// print the result.
			Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
			Console.ReadKey();
		}
	}
}
