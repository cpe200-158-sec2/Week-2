using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                bool logic = true;
                foreach (char c in value)
                {
                    if (!Char.IsDigit(c))
                    logic = false;
                }
                if (logic == false || value.Length > 6)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    _CourseID = value;
                }
            }
        }
        public string Lecturer
        {
            get { return _Lecturer; }
            set { _Lecturer = value; }
        }
        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {
                if (_NumStudents > value)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    _MaxStudents = value;
                }
            }
        }   
        public int NumStudents
        {
            get { return _NumStudents; }
            set
            {
                if(value <= _MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid No. Students!");
                }
            }
        }

        public Course()
        {
            _Name = "FlipFlop";
            _CourseID = "xxxx";
            _Lecturer = "Staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(string name , string ID)
        {
            Name = name;
            CourseID = ID;
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name , string ID , string lecture)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecture;
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name, string ID, string lecture , int max)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecture;
            MaxStudents = max;
            NumStudents = 0;
        }
        override public string ToString()
        {
            string output = "[Course: " + _Name + " (" + _CourseID + "), Lecturer=" + _Lecturer + ", has " + _NumStudents + " students, max=" + _MaxStudents + "]";
            return output;
        }

    }
}
