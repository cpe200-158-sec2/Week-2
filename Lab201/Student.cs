using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
        private string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set 
            {
                if (value >= 1950 && value <= 2000) 
                {
                    _YearOfBirth = value;
                }
                else
                {
                    Console.WriteLine(_StudentID + " : error try setting invalid year-of-birth value!");
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
            _Name = "John Doe";
            _StudentID = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;
        }

        public Student(string name, string ID)
        {
            Name = name;
            StudentID = ID;
            YearOfBirth = 1995;
            isActive = true;
        }

        public Student(string name, string ID , int yob)
        {
            Name = name;
            StudentID = ID;
            YearOfBirth = yob;
            isActive = true;
        }

        public Student(string name, string ID, int yob , bool active)
        {
            Name = name;
            StudentID = ID;
            YearOfBirth = yob;
            isActive = active;
        }
        //[Student: s1(57001), age=20, is active student]

        override public string ToString()
        {
            string output = "Student: " + _Name + " (" + _StudentID + "), age=" + getAge() + ", is ";
            if (_isActive == false) output = output + ("Not active student]");
            else output = output + ("active student]");
            return output;
        }

        public int getAge()
        {
            return 2015 - _YearOfBirth;
        }


    }
}
