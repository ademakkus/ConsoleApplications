using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _52_Event_Catch
{
	class Program
	{
		static void Main(string[] args)
		{


			var depo = new Depo(150); ///depo.StokSayisi = 50;
			depo.StokDegisti += Depo_StokDegisti;

			ForegroundColor = DarkBlue;
			WriteLine("++++++ Stok Mal Girişi +++++");
			depo.MalGirisi(50);
			//
			Console.WriteLine("Mevcut Stok : {0}", depo.MevcutStokSayisi);
			///
			ForegroundColor = DarkRed;
			WriteLine("------ Stok Mal Çıkışı ------");
			depo.MalCikisi(89);
			ForegroundColor = DarkGreen;
			WriteLine("Stok son hali : {0}", depo.MevcutStokSayisi);
			Console.ReadKey();
		}

		private static void Depo_StokDegisti()
		{
			ForegroundColor = DarkYellow;
			WriteLine(" !!! Stok değişti !");
		}
	}
}
