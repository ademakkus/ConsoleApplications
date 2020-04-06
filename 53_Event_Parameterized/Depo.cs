using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53_Event_Parameterized
{
	class Depo
	{
		//deegate metolarını taşımak için özel tiptir. delegate sınıf düzeyinde de tanımlanabilir. delegate metot referanslarını gösterebilen,işaret eden, bir tiptir.
		//delegate imzasına uygun tüm metotlara bir delegate referans edebilir
		public delegate void StoDegistiHandler(object sender,StokDegistiEventArgs e);//delegate tanımı 

		public event StoDegistiHandler StokDegisti; //delegate tipinde event 
		private int _stokSayisi;
		public void MalGirisi(int stokSayisi)
		{

			_stokSayisi += stokSayisi;
			//if (StokDegisti != null)
			//{
			//	SStokSayisi = _stokSayisi,
			// DegisimMiktari = stokSayisi
			//
			//}
			
			StokDegisti?.Invoke(this, new StokDegistiEventArgs()
			{
				StokSayisi = _stokSayisi,
				DegisimMiktari = stokSayisi
			}
				); 
			
		}
		public void MalCikisi(int stokSayisi)
		{
			_stokSayisi -= stokSayisi;
			////if (StokDegisti != null)
			//{
			//	StokDegisti(); 
			//}
			StokDegisti?.Invoke(this, new StokDegistiEventArgs()
			{
				StokSayisi = _stokSayisi,
				DegisimMiktari = stokSayisi
			});

		}
		public int MevcutStokSayisi
		{
			get { return _stokSayisi; }
			
		}
		public Depo(int stokSayisi)
		{
			_stokSayisi = stokSayisi;
		}
		//public Depo()
		//{

		//}
	}
}
