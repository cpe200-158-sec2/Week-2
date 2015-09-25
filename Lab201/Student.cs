using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        //Properties set to private.   

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
                    Console.WriteLine("({0}): error try setting invalid year - of - birth value!", _StudentID);
                }
                _YearOfBirth = value;
            }
        }
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        //Constructors

        public Student()
        {
            _Name = "John Doe";
            _StudentID = "(Unknown)";
            _YearOfBirth = 1995;
            _isActive = false;
        }
        public Student(string Name, string StudentID)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = 1995;
            _isActive = true;
        }
        public Student(string Name, string StudentID, int YearOfBirth)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = YearOfBirth;
            _isActive = true;
        }
        public Student(string Name, string StudentID, int YearOfBirth, bool isActive)
        {
            _Name = Name;
            _StudentID = StudentID;
            _YearOfBirth = YearOfBirth;
            _isActive = isActive;
        }


        //Method 

        public int getAge()
        {
            return 2015 - _YearOfBirth;
        }
        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}),age = {2}, is {3} student]", _Name, _StudentID, _YearOfBirth, (_isActive == true) ? "Active" : "NOT active");
        }

    }
}
