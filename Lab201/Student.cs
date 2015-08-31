using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _studentID;
        private string _name;
        private int _yearOfBirth;
        private bool _isActive;

        public string StudentID
        {
            get
            {
                return _studentID;
            }
            set
            {
                _studentID = value;
            }
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
        public int YearOfBirth
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID);
                }
                else
                {
                    _yearOfBirth = value;
                }
            }
        }
        public bool isActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        public int getAge()
        {
            return 2015 - _yearOfBirth;
        }
        public Student()
        {
            _name = "John Doe";
            _studentID = "Unknown";
            _yearOfBirth = 1995;
            _isActive = false;
        }
        public Student(string n, string id)
        {
            _name = n;
            _studentID = id;
            _yearOfBirth = 1995;
            _isActive = true;
        }
        public Student(string n, string id, int year)
        {
            _name = n;
            _studentID = id;
            _yearOfBirth = year;
            _isActive = true;
        }
        public Student(string n, string id, int year, bool a)
        {
            _name = n;
            _studentID = id;
            _yearOfBirth = year;
            _isActive = a;
        }
        public override string ToString()
        {
            string x;
            if(_isActive == true)
            {
                x = "is active student";
            }
            else
            {
                x = "is NOT active student";
            }
            string y;
            y = "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + " ," + x + "]";
            return y;
        }
    }
}
