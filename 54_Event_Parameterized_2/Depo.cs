using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Event_Parameterized_2
{
	class Depo
	{
		//deegate metolarını taşımak için özel tiptir. delegate sınıf düzeyinde de tanımlanabilir. delegate metot referanslarını gösterebilen,işaret eden, bir tiptir.
		//delegate imzasına uygun tüm metotlara bir delegate referans edebilir
		public delegate void StokDegistiHandler(object sender,StokDegistiEventArgs e);//delegate tanımı 

		public event StokDegistiHandler StokDegisti; //delegate tipinde event 
		private int _stokSayisi;
		public void MalGirisi(int stokSayisi)
		{

			_stokSayisi += stokSayisi;
		
			StokDegisti?.Invoke(this, new StokDegistiEventArgs()
			{
				StokSayisi = _stokSayisi,
				DegisimMiktari = stokSayisi,
				DegisimTuru = "Mal girişi oldu"

			});
			
			
		}
		public void MalCikisi(int stokSayisi)
		{
			_stokSayisi -= stokSayisi;
			StokDegisti?.Invoke(this, new StokDegistiEventArgs()
			{
				StokSayisi = _stokSayisi,
				DegisimMiktari = stokSayisi,
				DegisimTuru="Mal çıkışı oldu"
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
		
	}
}
