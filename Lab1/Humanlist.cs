using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Humanlist
    {
        private  List<Human> listHumans;

        public Humanlist()
        {
            listHumans = new List<Human>();
        }
        public void Add(Human human)
        {
            listHumans.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < listHumans.Count; n++)
                listHumans[n].PrintInfo();
        }
    }
}
