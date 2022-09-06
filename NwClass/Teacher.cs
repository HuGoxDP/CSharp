using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
	class Teacher : Human
	{
		public Teacher() : base()
		{
			List = new List<Student>();
		}
		public Teacher(string name, string surname, int age, double height,
				double weight, bool habbits, Nation nation, Adress adress, int salary, string department) : base(name, surname,
						age, height, weight, habbits, nation, adress)
		{
			this.Salary = salary;
			this.Department = department;
			this.List = new List<Student>();
		}
		public void Add(Student human)
		{
			List.Add(human);
		}
		public void Show()
		{
			for (int n = 0; n < List.Count; n++)
				List[n].PrintInfo();
		}
		public override void PrintInfo()
		{
			string data = "Name: " + this.Name + "\n" +
							 "Surname: " + this.Surname + "\n" +
							 "Age: " + this.Age.ToString() + "\n" +
							 "Height: " + this.Height.ToString() + "\n" +
							 "Weight: " + this.Weight.ToString() + "\n" +
							 "Is Habbits: " + this.Habbits.ToString() + "\n" +
							 "Nation: " + this.Nation.ToString() + "\n" +
							 "Adress: " + this.Adress.ToString() + "\n" +
							 "Salary: " + this.Salary.ToString() + "\n" +
							 "Money: " + this.Department;
			Console.WriteLine(data);
		}
		public int Salary { get; set; }
		public string Department { get; set; }
		public List<Student> List { get; set; }
	}
}
