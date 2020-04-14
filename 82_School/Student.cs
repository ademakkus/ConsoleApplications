using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_School
{
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Student(string firstName,string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}
		public string Name
		{

			get
			{
				return this.FirstName + " " + this.LastName;
			}
		}
		public override string ToString()
		{
			return "Student: " + this.Name;
		}
	}
}
