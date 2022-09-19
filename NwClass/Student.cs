using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
    public enum Key { csharp, python, java, JS }
    class Student : Human
    {
        private readonly int group;
        private readonly int money;
        private Key key;

        public Student(string name, string surname, int age, double height,
             double weight, bool habbits, string email, Nation nation, Adress adress, int group, int money, Key key) : base(name, surname,
                 age, height, weight, habbits, email, nation, adress)
        {
            this.group = group;
            this.money = money;
            this.key = key;
        }
        public int Group { get; set; }
        public int Money { get; set; }
        public Key Key
        {
            get { return key; }
            set { key = value; }

        }

        public override void PrintInfo()
        {
            string data =
              base.ToStr() + "\n" +
              "Group: " + this.group.ToString() + "\n" +
              "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString();
            Console.WriteLine(data);
        }
        public override string ToStr()
        {
            string str = base.ToStr();
            str +=
               "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString();
            return str;
        }

    }
}
