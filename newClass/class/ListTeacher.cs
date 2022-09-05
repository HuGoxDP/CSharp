using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
	internal class ListTeacher
    {
		private readonly List<Teacher> listTeacher;

		public ListTeacher()
        {
            listTeacher = new List<Teacher>();
        }
        public void Add(Teacher human)
        {
			listTeacher.Add(human);
        }
}
}
