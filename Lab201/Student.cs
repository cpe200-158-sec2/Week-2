using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _Name;
        private string _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }

        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} : error try setting invalid year-of-birth value!", StudentID);
                }
                else
                {
                    _YearOfBirth = value;
                }
            }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public Student()
        {
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = false;
        }

        public Student(string name, string studentID)
        {
            this.Name = name;
            this.StudentID = studentID;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }

        public Student(string name, string studentID, int yearOfBirth)
        {
            this.Name = name;
            this.StudentID = studentID;
            this.YearOfBirth = yearOfBirth;
            this.isActive = true;
        }

        public Student(string name, string studentID, int yearOfBirth, bool isActive)
        {
            this.Name = name;
            this.StudentID = studentID;
            this.YearOfBirth = yearOfBirth;
            this.isActive = isActive;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public override string ToString()
        {
            string ans;
            if (_isActive)
            {
                ans = "[Student: " + _Name + " (" + StudentID + "), age = " + getAge() + ", is active student]";
            }
            else
            {
                ans = "[Student: " + _Name + " (" + StudentID + "), age = " + getAge() + ", is NOT active student]";
            }
            return ans;
        }

    }
}