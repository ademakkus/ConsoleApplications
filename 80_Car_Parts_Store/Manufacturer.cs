using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_Car_Parts_Store
{
	/// <summary>
	/// Class describing manufacturer of parts
	/// </summary>
	public class Manufacturer
	{

		private string name;
		private string country;
		private string address;
		private string phoneNumber;
		private string fax;
	public Manufacturer(string name,string country,string address,string phoneNumber,string fax)
		{
			this.name = name;
			this.country = country;
			this.address = address;
			this.phoneNumber = phoneNumber;
			this.fax = fax;

		}

		
		public override string ToString()
		{

			return this.name + "<" + this.country + "," + this.address + "," + this.phoneNumber + "," + this.fax + ">";
		}

	}
}
