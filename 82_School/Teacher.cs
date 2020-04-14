using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_School
{
	public class Teacher
	{

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public List<Group> Groups { get; set; }

		public Teacher(string firstName,string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Groups = new List<Group>();
		}
		public string Name
		{
			get
			{
				return this.FirstName + ' ' + this.LastName;
			}
		}
		public override string ToString()
		{
			StringBuilder teacherAsString = new StringBuilder();
			teacherAsString.AppendLine("Teacher name : " + this.Name);
			teacherAsString.Append("Groups of this teacher :" +
				string.Join(",", this.Groups.Select(s => s.Name))


				);
			return teacherAsString.ToString();
		}
	}
}
