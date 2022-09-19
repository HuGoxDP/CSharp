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
        protected string _name;
        protected string _surname;
        protected int _age;
        protected double _height;
        protected double _weight;
        protected bool _habbits;
        protected string _email;
        protected Nation _nation;
        protected Adress _adress;
        protected Human()
        {
            Console.WriteLine("Создание объекта Person");
            this._name = "Oleksandr";
            this._surname = "Maidanika";
            this._age = 18;
            this._height = 1.69;
            this._weight = 70;
            this._habbits = false;
            this._nation = Nation.Ukranian;
        }
        public Human(string name, string surname, int age, double height, double weight, bool habbits, string email, Nation nation, Adress adress)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
            this._height = height;
            this._weight = weight;
            this._habbits = habbits;
            this._email = email;
            this._nation = nation;
            this._adress = adress;
        }
        public static Human operator +(Human one, Human two)
        {
            Human result = new Human
            {
                _age = one._age + two._age,
                _habbits = one._habbits && two._habbits
            };
            return result;
        }
        public static bool operator >(Human one, Human two)
        {
            bool result = one._age > two._age;
            return result;
        }
        public static bool operator <(Human one, Human two)
        {
            bool result = one._age < two._age;
            return result;
        }
        public virtual void PrintInfo()
        {
            string data =
                "Name: " + this._name + "\n" +
                "Surname: " + this._surname + "\n" +
                "Age: " + this._age.ToString() + "\n" +
                "Height: " + this._height.ToString() + "\n" +
                "Weight: " + this._weight.ToString() + "\n" +
                "Is Habbits: " + this._habbits.ToString() + "\n" +
                "Email: " + this._email + "\n" +
                "Nation: " + this._nation.ToString() + "\n" +
                "Adress: " + this._adress.ToString() + "\n";
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
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Nation: ");
            Nation nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            Adress adr = new Adress();
            Human n = new Human(name, surname, age, height, weight,  habbits, email, nation, adr.Inputadress());
            list.Add(n);
        }
        public virtual string ToStr()
        {
            string str = "Name: " + this._name + "\n" +
                    "Surname: " + this._surname + "\n" +
                    "Age: " + this._age.ToString() + "\n" +
                    "Height: " + this._height.ToString() + "\n" +
                    "Weight: " + this._weight.ToString() + "\n" +
                    "Is Habbits: " + this._habbits.ToString() + "\n" +
                    "Email: " + this._email + "\n" +
                    "Nation: " + this._nation.ToString() + "\n" +
                     "Adress: " + this._adress.ToString() + "\n";
                return str;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }


        public double Height { get; set; }

        public double Weight { get; set; }

        public bool Habbits { get; set; }

        public Nation Nation { get; set; }

        public Adress Adress { get; set; }
    }
}