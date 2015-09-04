using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string _name = "John Doe";
        private string _studentID = "Unknow";
        private int _yearOfBirth = 1995;
        private bool _isActive = false;
        public Student()
        {

            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 1995;
            IsActive = false;

        }
        public Student(string name, string studentID)
        {

            Name = name;
            StudentID = studentID;
            YearOfBirth = 1995;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth)
        {

            Name = name;
            StudentID = studentID;
            YearOfBirth = yearOfBirth;
            IsActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth, bool isActive)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = yearOfBirth;
            IsActive = isActive;
        }
        private int GetAge()
        {
            return 2015 - YearOfBirth;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string StudentID
        {
            get { return _studentID; }
            set
            {
                _studentID = value;
            }
        }
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set
            {

                if (value > 2000 || value < 1950)
                { Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID); }
                else _yearOfBirth = value;
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;

            }
        }
        public override string ToString()
        {
            if (_isActive)
                return string.Format("[Student: {0} ({1}), age={2}, is active student]", Name, StudentID, GetAge());
            else
                return string.Format("[Student: {0} ({1}), age={2}, is NOT active student]", Name, StudentID, GetAge());
        }

    }

}
