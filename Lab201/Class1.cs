using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string _name;
        private string _id;
        private int _year;
        private bool _active;

        public Student()
        {
            _name = "John Doe";
            _id = "Unknown";
            _year = 1995;
            _active = false;
        }

        public Student(string Name, string StudentID)
        {
            _name = Name;
            _id = StudentID;
            _year = 1995;
            _active = true;
        }

        public Student(string Name, string StudentID, int YearOfBirth)
        {
            _name = Name;
            _id = StudentID;
            _year = YearOfBirth;
            _active = true;
        }

        public Student(string Name,string StudentID, int YearOfBirth, bool isActive)
        {
            _name = Name;
            _id = StudentID;
            _year = YearOfBirth;
            _active = true;
        }

        public string Name
        {

            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
            
        }

        public string StudentID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
  
        }

        public int YearOfBirth
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
               
                    Console.WriteLine("{0} : error try setting invalid year-of-birth value!", _id);
                }
               else _year = value;
            }
        }

        public bool isActive
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        public int getAge()
        {
            return 2015 - _year;
        }

        public override string ToString()
        {
            string st;
            if (_active)

            {
                st = "[Student: " + _name + "(" + _id + "),age = "+ getAge() + ", is active student.]";

            }
            else
            {
                st = "[Student: " + _name + "(" + _id + "),age = "+ getAge() + ", is NOT active student.]";
            }

            return st;
            
        }
    }
}
