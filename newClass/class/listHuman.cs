using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class listHuman
    {
        private List<Human> listHumans;
        
        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void add(Human human)
        {
            listHumans.Add(human);
        }
        public void show()
        {
            for (int n = 0; n < listHumans.Count(); n++)
                listHumans[n].printInfo();
        }
        public string show(int a)
        {
            string data = "";
            for(int n = 0; n < listHumans.Count(); n++)
                data += listHumans[n].toStr();
            return data;
        }
        public void findCountry_Nation(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
                if (listHumans[n].Adress.Country == str && 
                    listHumans[n].Nation.ToString() == "Ukranian")
                    listHumans[n].printInfo();
        }
        public void findName(string str)
        {
            for (int n = 0; n < listHumans.Count(); n++)
            {
                if (listHumans[n].Name == str)
                    listHumans[n].printInfo();
            }

        }
        /*public void sort()
        {
        
        }*/
        public void average_age()
        {
            int age = 0;
            for (int n = 0; n < listHumans.Count(); n++)
                age += listHumans[n].Age;
            if (listHumans.Count() != 0) {
                float result = age / listHumans.Count();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Список пустой");
            }

        }
        public void show(bool b)
        {
            foreach (Human obj in listHumans)
                obj.printInfo();
        }
    }
}
