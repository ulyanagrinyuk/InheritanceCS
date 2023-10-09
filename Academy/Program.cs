//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Academy
{
	internal class Program
	{

		public static readonly string delimiter = "\n------------------\n";
		static void Main(string[] args)
		{
#if WRITE_TO_FILE

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
			//Console.WriteLine(graduate);
			//Console.WriteLine(delimiter);

			Student tommy = new Student(human, "Theft", "Vice", 98, 99);
			//Console.WriteLine(tommy);
			//Console.WriteLine(delimiter);

			Human[] group = new Human[] {teacher, student, graduate, tommy,
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 25)};
			new Graduate("Rosenberg", "Ken", 35, "Lower", "Vice", 44, 55, "Get mony back");
			for (int i = 0; i < group.Length; i++)
			{
				//Console.WriteLine(group[i]);
				group[i].Print();
				Console.WriteLine(delimiter);
			}
#endif
			Human[] group = Load("group.txt");
			for(int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
			//string file = "group.txt";
			//StreamReader f = new StreamReader(file);// для открытия, чтения и закрытия текстового файла.
			//for (int i = 0; i < group.Length; i++)
			//{
			//	string line = f.ReadLine();
			//Console.WriteLine($"Line {i+1}: {line}");
			//         }
			//f.Close();// закрывает и разъединяет файл filestream, связанный с потоком.
			//Process.Start("group.txt", file);//вызываем фаил в качестве параметра. 

			Save(group, "group.csv");
		}
		
		static void Save(Human[] group, string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			string currentDirectory = Directory.GetCurrentDirectory();
			//string filename = "group.txt";
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine($"{group[i].GetType()}:\t{group[i]}");
			}
			sw.Close();

			string cmd = $"{currentDirectory}\\{filename}";
			System.Diagnostics.Process.Start("notepad", cmd);
		}

		static Human[] Load(string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			Console.WriteLine(Directory.GetCurrentDirectory());
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				string[] values = buffer.Split(':', ',', ';');
				group.Add(HumanFactory(values[0]));
				group.Last().Init(values);
			}
			sr.Close();
			return group.ToArray();
		}
		static Human HumanFactory(string type)
		{
			Human human = null;
			if (type == typeof(Academy.Student).ToString()) human = new Student("", "", 0, "", "", 0, 0);
			if (type == typeof(Academy.Teacher).ToString()) human = new Teacher("", "", 0, "", 0);
			if (type == typeof(Academy.Graduate).ToString()) human = new Graduate("", "", 0, "", "", 0, 0, "");
			return human;
		}
	}

}
