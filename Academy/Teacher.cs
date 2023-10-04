using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher:Human
	{
	public 	string Speciality {  get; set; }
		public int Experiance { get; set; }
		public Teacher
			(
			string lastName, string firstName, int age,
			string speciality, int experiance
			):base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experiance = experiance;
            Console.WriteLine($"TConstuctor:\t{this.GetHashCode()}");
        }

		public Teacher(Teacher other):base(other)
		{
			this.Speciality = other.Speciality;
			this.Experiance = other.Experiance;
            Console.WriteLine($"TCopyConstructor:{this.GetHashCode()}");
        }
		~Teacher()
		{
			Console.WriteLine($"TDonstuctor:\t{this.GetHashCode()}");
		}
		public override string ToString()
		{
			return base.ToString() + " " + $"{Speciality} {Experiance}";
		}
		public override void Print()
		{
			base.Print() ;
			Console.WriteLine("Speciality\t" +  Speciality);
			Console.WriteLine("Experiance\t" +  Experiance);
		}
	}
}
