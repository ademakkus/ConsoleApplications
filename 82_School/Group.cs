using _82_School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82_School
{


	
	}
	public class Group
	{

		public string Name { get; set; }
		public List<Student> Students { get; set; }
	public Teacher Teacher { get; set; }

		public Group(string name)
		{

			this.Name = name;
			this.Students = new List<Student>();

		}
		public override string ToString()
		{
			StringBuilder groupAsString = new StringBuilder();
			groupAsString.AppendLine("Group name :" + this.Name);
			groupAsString.Append("Students in the group :" + String.Join(",", this.Students.Select(s => s.Name)));

		
		
		if (this.Teacher!=null)
		{
			groupAsString.AppendLine("\nGroup teacher : " + this.Teacher.Name);
		}

			return groupAsString.ToString();

		}
	}
	

