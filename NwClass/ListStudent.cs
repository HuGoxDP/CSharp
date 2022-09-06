using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
    internal class ListStudent
    {
        private List<Student> list;
        public ListStudent()
        {
            list = new List<Student>();
        }

        public void Add(Student human)
        {
            list.Add(human);
        }
        public void Show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].PrintInfo();
        }
        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }

    }
}
