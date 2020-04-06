using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52_Event_Catch
{
	class Depo
	{
		//deegate metolarını taşımak için özel tiptir. delegate sınıf düzeyinde de tanımlanabilir. delegate metot referanslarını gösterebilen,işaret eden, bir tiptir.
		//delegate imzasına uygun tüm metotlara bir delegate referans edebilir
		public delegate void StoDegistiHandler();//delegate tanımı 

		public event StoDegistiHandler StokDegisti; //delege tipinin event'ını bldirme
		private int _stokSayisi;

		

		public void MalGirisi(int stokSayisi)
		{

			_stokSayisi += stokSayisi;
			//if (StokDegisti != null)
			//{
			//	StokDegisti();
			//}
			StokDegisti?.Invoke();
		}
		public void MalCikisi(int stokSayisi)
		{
			_stokSayisi -= stokSayisi;
			////if (StokDegisti != null)
			//{
			//	StokDegisti(); 
			//}
			StokDegisti?.Invoke();

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
