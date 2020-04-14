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
	/// Class describing a car
	/// Represents the standard brand, model, and error streams for console applications.
	/// </summary>
	public class Car
	{
		private string brand;
		private string model;
		private int productionYear;

		/// <summary>
		/// Intialize Car object
		/// </summary>
		/// <param name="brand">car brand</param>
		/// <param name="model">car model</param>
		/// <param name="productionYear">car production year</param>
		public Car(string brand,string model,int productionYear)
		{
			this.brand = brand;
			this.model = model;
			this.productionYear = productionYear;

			
		}
		/// <summary>
		///  Returns a string that represents the current object.
		/// </summary>
		/// <returns> A string that represents the current object.</returns>
		public override string ToString()
		{
			return "<" + this.brand + "," + this.model + "," + this.productionYear + ">";
		}
		//
		// Summary:
		//     Determines whether the specified object is equal to the current object.
		//
		// Parameters:
		//   obj:
		//     The object to compare with the current object.
		//
		// Returns:
		//     true if the specified object is equal to the current object; otherwise, false.
		public override bool Equals(object obj)
		{

		
			Car otherCar = obj as Car;
			if (otherCar == null)
			{
				return false;

			}
			bool equals =
				object.Equals(this.brand, otherCar.brand) &&
				object.Equals(this.model, otherCar.model) &&
				object.Equals(this.productionYear, otherCar.productionYear);
			return equals;
		}
		public override int GetHashCode()
		{
			
			const int prime = 31;
			int result = 1;
			result = prime * result + ((this.brand == null) ? 0 :
			this.brand.GetHashCode());
			result = prime * result + ((this.model == null) ? 0 :
			this.model.GetHashCode());
			result = prime * result + this.productionYear;
			return result;
		}
	}
}
