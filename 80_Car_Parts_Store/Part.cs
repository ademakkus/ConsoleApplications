using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _80_Car_Parts_Store
{

	/// <summary>
	///Class describing part for a car
	/// </summary>
	public class Part
	{
		private string name;
		private string code;
		private PartCategory category;
		private HashSet<Car> supportedCars;
		private decimal buyPrice;
		private decimal sellPrice;
		private Manufacturer manufacturer;
		public Part(string name,decimal buyPrice,decimal sellPrice,Manufacturer manufacturer,string code,PartCategory category)
		{

			this.name = name;
			this.buyPrice = buyPrice;
			this.sellPrice = sellPrice;
			this.manufacturer = manufacturer;
			this.code = code;
			this.category = category;
			this.supportedCars = new HashSet<Car>();
		}
		public void AddSupportedCar(Car car)
		{
			this.supportedCars.Add(car);
		}
		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append("Part : " + this.name + "\n");
			result.Append(" -code : " + this.code + "\n");
			result.Append(" -category : " + this.category + "\n");
			result.Append(" -buyPrice : " + this.buyPrice + "\n");
			result.Append(" -sellPrice: " + this.sellPrice + "\n");
			result.Append(" -manufactrer : " + this.manufacturer + "\n");
			result.Append(" --Supported cars --- : " + this.name + "\n");
			foreach (Car car in this.supportedCars)
			{
				result.Append(car);
				result.Append("\n");
			}
			result.Append("-------------------------\n");
			return result.ToString();

		}
		

	}
}
