using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{


    class Student
    {
        private string _name;
        private int _year;
        private string _id;
        private bool _active;

       // prop
        public int YearOfBirth
        {
            get { return _year; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine(Id+" error try setting invalid year-of-birth value");
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool isActive
        {
            get { return _active; }
            set { _active = value; }
        }

       // medtod

        public Student()
        {
            this.Name = "John Doe";
            this.Id = "(Unknow)";
            this.YearOfBirth = 1995;
            this.isActive = false;
        }
        public Student(string name, string id)
        {
            this.Name = name;
            this.Id = id;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }
        public Student(string name, string id, int year)
        {
            this.Name = name;
            this.Id = id;
            this.YearOfBirth = year;
            this.isActive = true;
        }
        public Student(string name, string id, int year, bool active)
        {
            this.Name = name;
            this.Id = id;
            this.YearOfBirth = year;
            this.isActive = active;
        }
        public int getAge()
        {
            return 2015 - YearOfBirth;
        }


        public override string ToString()
        {
            string active = "";
            if (isActive == true)
            {
                active = "Active";
            }
            else
            {
               active = "Not Active";
            }

            string k = "[Student: " + Name + "(" +Id + ")," + "age:" + getAge()+ ", " + active + " student]";

            return k;
        }


    }
}
