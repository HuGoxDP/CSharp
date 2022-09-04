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
            Human two = new Human("Alex", "Ker", 19, 1.84, 100, true, Nation.Polish, new Adress("Polish", "Jahj", "Thgg", 5));
            Human three = new Human("Antony", "admant", 17, 1.86, 89, false, Nation.French, new Adress("French", "Oves", "Almat", 1));
            Human four = new Human("Kiril", "Scroll", 23, 1.74, 75, true, Nation.Ukranian, new Adress("Ukranian", "Oda", "Thu", 4));

            listHuman list = new listHuman();
            list.add(one);
            list.add(two);
            list.add(three);
            list.add(four);
            Console.WriteLine("Выберите действие ");
            Console.WriteLine("1 - распечатать все объекты");
            Console.WriteLine("2 - найти объект по имени");
            Console.WriteLine("3 - средний возраст");
            Console.WriteLine("4 - сортировка по ...");
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
                case 4:
                    Console.WriteLine(" 1 - Возраст \n 2 - вес \n 3 - рост");
                    int ij = int.Parse(Console.ReadLine());
                    switch (ij) {
                        case 1:
                        list.Age_weight_height_sort(1);
                            break;
                            case 2:
                        list.Age_weight_height_sort(2);
                            break;
                        case 3:
                        list.Age_weight_height_sort(3);
                            break;
                        default:
                            Console.WriteLine("Вы ввели неверный номер!");
                            break;
                        }

                    break;
                default:
                    Console.WriteLine("Вы ввели неверный номер!");
                    break;

            }
            Console.ReadLine();
        }
    }
}
