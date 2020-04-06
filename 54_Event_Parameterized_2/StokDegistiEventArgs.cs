using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Event_Parameterized_2
{
	class StokDegistiEventArgs:EventArgs
	{
		public int StokSayisi { get; set; }
		public int DegisimMiktari { get; set; }
		public string DegisimTuru { get; set; }
	}
}
