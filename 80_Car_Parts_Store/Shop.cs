using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80_Car_Parts_Store
{
	public class Shop
	{
		private string name;
		private List<Part> parts;
		public Shop(string name)
		{

			this.name = name;
			this.parts = new List<Part>();
		}
		/// <summary>
		/// Adds an object to the end of the parts object
		/// </summary>
		/// <param name="part">The object to be added to the end of the  parts object.  value can be null for reference types. </param>
		public void AddPart(Part part)
		{
			this.parts.Add(part);
		}
		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append("Shop: " + this.name + "\n\n");
			foreach (Part part in this.parts)
			{
				result.Append(part);
				result.Append("\n");
			}

			return result.ToString();

		}
	}
}
