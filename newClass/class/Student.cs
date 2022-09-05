using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Student : Human
    {
        private readonly int group;
        private readonly int money;

        public Student(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Adress adress,
            int group, int money) : base(name, surname, age, height, weight, habbits, nation, adress)
        {
            this.group = group;
            this.money = money;
        }
        public int Group { get; set; }
        public int Money { get; set; }
        new public void InputInfo(ListHuman listHuman) // сделать инпут с этим именем 
		{
			if (listHuman == null)
				throw new ArgumentNullException(nameof(listHuman));

			Console.WriteLine("Group :");
			_ = int.Parse(Console.ReadLine());
			Console.WriteLine("money :");
			_ = int.Parse(Console.ReadLine());
		}

		public override void PrintInfo()
        {
            string data =
            "Name: " + this.Name + "\n" +
            "Surname: " + this.Surname + "\n" +
            "Age: " + this.Age.ToString() + "\n" +
            "Height: " + this.Height.ToString() + "\n" +
            "Weight: " + this.Weight.ToString() + "\n" +
            "Is Habbits: " + this.Habbits.ToString() + "\n" +
            "Nation: " + this.Nation.ToString() + "\n" +
            "Adress: " + this.Adress.ToString() + "\n" +
            "Group: " + this.group.ToString() +"\n"+
             "Money: " + this.money.ToString();
            Console.WriteLine(data);
        }
    }
}
