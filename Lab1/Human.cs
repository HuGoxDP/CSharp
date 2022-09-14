using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private double height;
        private double weight;
        private Adress adress;

        protected Human()
        {
            this.name = "Oleksandr";
            this.surname = "Maidanika";
            this.age = 18;
            this.height = 1.69;
            this.weight = 70;
        }
        public Human(string name, string surname, int age, double height, double weight, Adress adress)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.adress = adress;
        }
        public void PrintInfo()
        {
            string data =
                "Name: " + this.name + "\n" +
                "Surname: " + this.surname + "\n" +
                "Age: " + this.age.ToString() + "\n" +
                "Height: " + this.height.ToString() + "\n" +
                "Weight: " + this.weight.ToString() + "\n" +
                "Adress: " + this.adress.ToString();
            Console.WriteLine(data);
        }
        public string ToStr()
        {
            string str = "Name: " + this.name + "\n" +
                    "Surname: " + this.surname + "\n" +
                    "Age: " + this.age.ToString() + "\n" +
                    "Height: " + this.height.ToString() + "\n" +
                    "Weight: " + this.weight.ToString();
            return str;
        }
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public Adress Adress { get; set; }
    }
}
    

