using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
    internal class ListTeacher
    {
        private List<Teacher> list;
        public ListTeacher()
        {
            list = new List<Teacher>();
        }

        public void Add(Teacher human)
        {
            list.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].PrintInfo();
        }
        public List<Teacher> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
