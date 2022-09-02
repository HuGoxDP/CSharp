using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    
  
    class Program
    {   
        static void Main(string[] args)
        {
            List<Human> listHuman = new List<Human>();
            Adress add1 = new Adress("Ukraine", "Kherson", "Perekopskaya", 3);
            Human one = new Human("Alesia", "Tantsiurenko", 18, 1.84, 60, false, Nation.Ukranian, add1);
            Human two = new Human("Alex", "Ker", 18, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5));

            listHuman list = new listHuman();
            list.add(one);
            list.add(two);
            Console.WriteLine("Выберите действие ");
            Console.WriteLine("1 - распечатать все объекты");
            Console.WriteLine("2 - найти объект по имени");
            Console.WriteLine("3 - сортировка");
            Console.WriteLine("4 - удалить объект");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    list.show();
                    break;
                case 2:
                    Console.WriteLine("Введите имя ");
                    string name = Console.ReadLine();
                    list.findName(name);
                    break;
                case 3:
                    list.average_age();
                    break;
                default:
                    Console.WriteLine("Вы ввели неверный номер!");
                    break;

            }
            Console.ReadLine();
        }
    }
}
