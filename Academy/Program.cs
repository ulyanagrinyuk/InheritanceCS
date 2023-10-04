using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		public static readonly string delimiter = "\n------------------\n";
		static void Main(string[] args)
		{
			Human human = new Human("Montana", "Antonio", 30);
   //         Console.WriteLine(human);
			//Console.WriteLine(delimiter);

			Student student = new Student("Pinikman", "Jessie", 25, "Chemistry", "WW_220", 90, 99);
            //Console.WriteLine(student);
            //Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walet", 50, "Chemistry", 25);
            //Console.WriteLine(teacher);
            //Console.WriteLine(delimiter);

			Graduate graduate = new Graduate("Hank", "Scherader", 40, "Criminalistic", "OBN", 80, 70, " How to catch Heisenbereg");
   //         Console.WriteLine(graduate);
			//Console.WriteLine(delimiter);

			Student tommy = new Student(human, "Theft", "Vice", 98, 99);
			//Console.WriteLine(tommy);
			//Console.WriteLine(delimiter);

			Human[] group = new Human[] {teacher, student, graduate, tommy,
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 25)};
       for(int i = 0; i < group.Length; i++)
			{
				//Console.WriteLine(group[i]);
				group[i].Print();
                Console.WriteLine(delimiter);
            }
		}
	}
}
