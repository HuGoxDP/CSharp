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
        public void Age_weight_height_sort(int choise)
        {
            
            int length_humans = listHumans.Count();
		double[] age_weight_height = new double[length_humans];
            int[] count_hum = new int[length_humans];
            for(int n = 0; n < length_humans; n++)
            {
                count_hum[n] = n;
            if (choise == 1){age_weight_height[n] = listHumans[n].Age;}
            else if(choise == 2){age_weight_height[n] = listHumans[n].Weight;}
            else if(choise == 3){age_weight_height[n] = listHumans[n].Height;}
                
            }
		    int j = length_humans - 1;
		    for (int b = 0; b < j; b++) {
			    for (int i = j; i != 0; i--) {
				    if (age_weight_height[i] < age_weight_height[i - 1]) {
					    double temp = age_weight_height[i];
					    age_weight_height[i] = age_weight_height[i - 1];
					    age_weight_height[i - 1] = temp;
                        int temp_count = count_hum[i];
					    count_hum[i] = count_hum[i - 1];
					    count_hum[i - 1] = temp_count;
				     }
			    }
		    }
            if (listHumans.Count() != 0) {
               Console.WriteLine("Список отсортирован");
               for(int k = listHumans.Count()-1 ; k >= 0; k--)
                {
                    listHumans[count_hum[k]].printInfo();
                }
            }
            else
            {
                Console.WriteLine("Список пустой");
            }
        }
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
