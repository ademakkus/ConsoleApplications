using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Event_Parameterized
{
	class StokDegistiEventArgs:EventArgs
	{
		public int StokSayisi { get; set; }
		public int DegisimMiktari { get; set; }
	}
}
