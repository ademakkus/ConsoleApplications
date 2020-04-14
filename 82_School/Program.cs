using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;

namespace _82_School
{
	class Program
	{
		static void Main(string[] args)
		{

			// Create a few students
			Student studentGeorge = new Student("George", "REDWOOD");
			Student studentElon  = new Student("Elon", "MUSK");
			Student studentSteve  = new Student("Steve", "JOBS");
			Student studentPeter  = new Student("Peter", "LEE");
			Student studentMaria  = new Student("Maria", "STEWARD");
			Student studentMike  = new Student("Michael", "ROBINSON");
			// Create a group and add a few students to it
			Group groupEnglish = new Group("English Language Course");
			groupEnglish.Students.Add(studentPeter);
			groupEnglish.Students.Add(studentMike);
			groupEnglish.Students.Add(studentMaria);
			groupEnglish.Students.Add(studentGeorge);
			Group groupFrench=new Group("French Language Course");
			groupEnglish.Students.Add(studentPeter);
			groupEnglish.Students.Add(studentMike);
			groupEnglish.Students.Add(studentMaria);
			groupEnglish.Students.Add(studentGeorge);
			Group groupCSharp = new Group("C# Programming Course");
			groupCSharp.Students.Add(studentElon);
			groupCSharp.Students.Add(studentSteve);
			groupCSharp.Students.Add(studentPeter);
			groupCSharp.Students.Add(studentGeorge);
			groupCSharp.Students.Add(studentMaria);
			Group groupJava = new Group("Java Programming COurse");
			groupEnglish.Students.Add(studentMike);
			groupEnglish.Students.Add(studentMaria);
			// Create a teacher and assign it to few groups
			Teacher teacherNatasha = new Teacher("Natasha", "WALTERS");

			Teacher teacherAdem = new Teacher("Adem", "AKKUŞ");
			Teacher teacherGulten = new Teacher("Gülten", "ALDEMİR");
			groupFrench.Teacher = teacherGulten;
			groupJava.Teacher = teacherAdem;
			groupCSharp.Teacher = teacherAdem;

			// Create a school with few students, groups and teachers
			School school = new School("Adem AKUS IT School");
			school.Students.Add(studentGeorge);
			school.Students.Add(studentElon  );
			school.Students.Add(studentSteve );
			school.Students.Add(studentPeter );
			school.Students.Add(studentMaria);
			school.Students.Add(studentMike);
			school.Groups.Add(groupEnglish);
			school.Groups.Add(groupJava);
			school.Groups.Add(groupCSharp);
			school.Groups.Add(groupFrench);
			school.Teachers.Add(teacherNatasha);
			school.Teachers.Add(teacherAdem);
			school.Teachers.Add(teacherGulten);
			groupEnglish.Teacher = teacherNatasha;
			
			ForegroundColor = DarkYellow;

			WriteLine(groupEnglish);

			ForegroundColor = DarkGray;
			WriteLine("School  Name: {0} ",school.Name);
			WriteLine();
			ForegroundColor = DarkGreen;
			WriteLine("School : {0} ", string.Join(", ", school.Groups.Select(g => g.Name)));
			WriteLine();
			ForegroundColor = DarkGray;
			WriteLine("School Teachers : {0} ", string.Join(", ", school.Teachers.Select(t => t.Name)));

			WriteLine();
			ForegroundColor = DarkYellow;
			WriteLine("School  Students : {0} ", string.Join(", ", school.Students.Select(s => s.Name)));

			


			ReadKey();

		}
	}
}
