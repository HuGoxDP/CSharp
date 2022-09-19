using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Xml.Serialization;

namespace NwClass
{
	public enum KeyWords { csharp, python, java, JS }
	class Teacher : Human
	{
		private int salary;
		private string department;
		private int numofseats;
		private KeyWords keywords;
		private List<Student> List;
		public Teacher() : base()
		{
			List = new List<Student>();
		}
		public Teacher(string name, string surname, int age, double height,
			double weight, bool habbits, string email, Nation nation, Adress adress, int salary, string department, int numofseats, KeyWords keywords) : base(name, surname,
				age, height, weight, habbits, email, nation, adress)
		{
			this.salary = salary;
			this.department = department;
			this.numofseats = numofseats;
			this.keywords = keywords;
			this.List = new List<Student>();
		}
		public void add(Student student)
		{
			if (check_numofset(student.Key.ToString()))
				list.Add(student);
			else
			{
				Console.WriteLine("Мест нет либо интересы не совпадают!");
			}
		}
		public void Show()
		{
			for (int n = 0; n < List.Count; n++)
				List[n].PrintInfo();
		}
		public override void PrintInfo()
		{
			string data =
			   base.ToStr() + "\n" +
			   "Salary: " + this.salary.ToString() + "\n" +
			   "Money: " + this.department + "\n" +
				"Number of set: " + this.numofseats.ToString() + "\n" +
				"Key: " + this.keywords.ToString();
			Console.WriteLine(data);
		}
		public bool check_numofset(string key)
		{
			bool check = false;
			if ((List.Count < numofseats) && (key == keywords.ToString()))
				check = true;
			else
			{
				check = false;
			}
			return check;
		}


		public override string  ToStr()
		{
			string str = base.ToStr();
			str +=
						"Salary: " + this.Salary.ToString() + "\n" +
						"Money: " + this.Department;
			return str;
		}

		public int Salary
		{
			get { return salary; }
			set { salary = value; }
		}
		public string Department
		{
			get { return department; }
			set { department = value; }
		}
		public int NumOfSeats
		{
			get { return numofseats; }
			set { numofseats = value; }
		}
		public KeyWords KeyWords
		{
			get { return keywords; }
			set { keywords = value; }
		}
		public List<Student> List
		{
			get { return list; }
			set { list = value; }
		}
	}
}
