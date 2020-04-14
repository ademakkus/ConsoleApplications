using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _80_Car_Parts_Store
{
	class Program
	{
		static void Main(string[] args)
		{

			//Manufacturer bmw = new Manufacturer("BMW", "Germany", "Bavari", "6644994", "88899933");

			//Part partEngineOil = new Part("BMW Engine Oil", 633.17m, 670.0m, bmw, "Oil431");

			//Car bmw316i = new Car("BMW", "316i", 1994);
			//partEngineOil.AddSupportedCar(bmw316i);
			//Car mazdaMX5 = new Car("Mazda", "MX5", 1999);
			//partEngineOil.AddSupportedCar(mazdaMX5);


			//WriteLine(partEngineOil);

			Manufacturer bmw = new Manufacturer("BWM", "Germany", "Bavaria", "665544", "876666");
			Manufacturer lada = new Manufacturer("Lada", "Russia", "Moscow", "653443", "893321");

			Car bmw316i = new Car("BMW", "316i", 1994);
			Car ladaSamara = new Car("Lada", "Samara", 1987);
			Car mazdaMX5 = new Car("Mazda", "MX5", 1999);
			Car mercedesC500 = new Car("Mercedes", "C500", 2008);
			Car trabant = new Car("Trabant", "super", 1966);
			Car opelAstra = new Car("Opel", "Astra", 1997);

			Part cheapPart = new Part("Tires 165/50/R13", 302.36m, 345.58m, lada, "T332", PartCategory.Tires);

			cheapPart.AddSupportedCar(ladaSamara);
			cheapPart.AddSupportedCar(trabant);

			Part expensivePart = new Part("Universal Car Engine",
			6733.17m, 6800.0m, bmw, "EU33", PartCategory.Engine);
			expensivePart.AddSupportedCar(bmw316i);
			expensivePart.AddSupportedCar(mazdaMX5);
			expensivePart.AddSupportedCar(mercedesC500);
			expensivePart.AddSupportedCar(opelAstra);

			Shop newShop = new Shop("Tuning Pro Shop");
			newShop.AddPart(cheapPart);
			newShop.AddPart(expensivePart);
			WriteLine(newShop);
			ReadKey();
		}
	}
}
