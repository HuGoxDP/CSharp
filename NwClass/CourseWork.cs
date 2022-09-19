using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwClass
{
    struct UDC
    {
        private int id;
        private string udc;
        public UDC(int id, string udc)
        {
            this.id = id;
            this.udc = udc;
        }
        public int Id
        {
            get { return id; }
            set { id = value;}
        }
        public string Udc
        {
            get { return udc; }
            set { udc = value; }
        }
        public void PrintInfo()
        {
            string text = 
                "id: " + id + "\n" +
                 "UDC: " + udc;
            Console.WriteLine(text);
        }
    }
    class CourseWork
    {
        private string description;
        private string name;
        private DateTime date;
        private UDC udc;
        public CourseWork(string description, string name, DateTime date, UDC udc)
        {
            this.description = description;
            this.name = name;
            this.date = date;
            this.udc = udc;
        }

        public void PrintInfo()
        {
            string text = "Description: " + description + "\n" +
                 "Name: " + name + "\n" +
                 "Date: " + date +"\n"+
                 "UDC: " + udc;
            Console.WriteLine(text);
        }
        public string StrInfo()
        {
            return "Description: " + description + "\n" +
                 "Name: " + name + "\n" +
                 "Date: " + date + "\n" +
                 "UDC: " + udc;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public UDC Udc
        {
            get { return udc; }
            set { udc = value; }
        }
    }
}