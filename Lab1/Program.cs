using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human("Oleksandr", "Maidanika", 18, 1.69, 70, new Adress("Ukraine", "Kherson", "Ilicha", 91));
            Human person2 = new Human("Alexandr", "Pitrienkp", 19, 1.84, 100,  new Adress("Polish", "Horda", "Hjfdd", 7));
            Human person3 = new Human("Antony", "admant", 17, 1.86, 89, new Adress("French", "Oves", "Almat", 1));
            Human person4 = new Human("Kiril", "Scroll", 23, 1.74, 75, new Adress("Ukranian", "Oda", "Thu", 4));
            Humanlist listHuman = new Humanlist();
            listHuman.Add(person1);
            listHuman.Add(person2);
            listHuman.Add(person3);
            listHuman.Add(person4);
            listHuman.Show();
        }
    }
}
