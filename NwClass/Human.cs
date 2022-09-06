using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
    enum Nation { Ukranian, French, Polish };
    class Human
    {
        protected Human()
        {
            Console.WriteLine("Создание объекта Person");
            this.Name = "Oleksandr";
            this.Surname = "Maidanika";
            this.Age = 18;
            this.Height = 1.69;
            this.Weight = 70;
            this.Habbits = false;
            this.Nation = Nation.Ukranian;
        }
        public Human(string name, string surname, int age, double height, double weight, bool habbits, Nation nation, Adress adress)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.Habbits = habbits;
            this.Nation = nation;
            this.Adress = adress;
        }
        public static Human operator +(Human one, Human two)
        {
            Human result = new Human
            {
                Age = one.Age + two.Age,
                Habbits = one.Habbits && two.Habbits
            };
            return result;
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one.Age > two.Age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one.Age < two.Age;
            return result;
        }
        public virtual void PrintInfo()
        {
            string data =
                "Name: " + this.Name + "\n" +
                "Surname: " + this.Surname + "\n" +
                "Age: " + this.Age.ToString() + "\n" +
                "Height: " + this.Height.ToString() + "\n" +
                "Weight: " + this.Weight.ToString() + "\n" +
                "Is Habbits: " + this.Habbits.ToString() + "\n" +
                "Nation: " + this.Nation.ToString() + "\n" +
                "Adress: " + this.Adress.ToString();
            Console.WriteLine(data);
        }
        public static void InputInfo(ListHuman list)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Habbits: ");
            bool habbits = bool.Parse(Console.ReadLine());
            Console.WriteLine("Nation: ");
            Nation nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            Adress adr = new Adress();
            Human n = new Human(name, surname, age, height, weight, habbits, nation, adr.Inputadress());
            list.Add(n);
        }
        public string ToStr
        {
            get
            {
                string str = "Name: " + this.Name + "\n" +
                        "Surname: " + this.Surname + "\n" +
                        "Age: " + this.Age.ToString() + "\n" +
                        "Height: " + this.Height.ToString() + "\n" +
                        "Weight: " + this.Weight.ToString() + "\n" +
                        "Is Habbits: " + this.Habbits.ToString() + "\n" +
                        "Nation: " + this.Nation.ToString() + "\n";
                return str;
            }
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public bool Habbits { get; set; }

        public Nation Nation { get; set; }

        public Adress Adress { get; set; }

    }
}