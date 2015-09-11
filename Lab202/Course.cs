using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab28
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        /// ///////////    
        public int Numstudents
        {
            get { return _NumStudents; }
            set { _NumStudents = value; }
        }
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
                if (value.Length == 6)
                {
                    bool chek = true;
                    foreach (char n in value)
                    {
                        chek=char.IsDigit(n);
                        if (chek != true)
                        {
                            Console.WriteLine(value + ": error try setting invalid CourseID!");
                            break;
                        }

                    }
                    if (chek == true)
                    {
                        _CourseID = value;
                    }
                }
                else
                {
                    Console.WriteLine(value + ": error try setting invalid CourseID!");
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
            set {
                    if (value <= 80 && value >= 0 && value >= Numstudents)
                    {
                    _MaxStudents = value;
                    }
                    else
                    {
                         Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!");
                    }
                }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set {
                if (value <= MaxStudents && value >= 0)
                {
                    _NumStudents = value;
                }  
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid  No. Students!");
                }

                }
        }
        public Course()
        {
            _Name = "---";
            _CourseID = "---";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(string n, string cos)
        {
            _Name = n;
            _CourseID = cos;
            _Lecturer = "STAFF";
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(string n, string cos, string lec)
        {
            _Name = n;
            _CourseID = cos;
            _Lecturer = lec;
            _MaxStudents = 30;
            _NumStudents = 0;
        }
        public Course(string n, string cos, string lec, int m)
        {
            _Name = n;
            _CourseID = cos;
            _Lecturer = lec;
            _MaxStudents = m;
        }

        public override string ToString()
        {
            string output = "[Course:" + Name + "(" + CourseID + "),Lecturer " + Lecturer + " has " + NumStudents + " Student, Max" + MaxStudents + "]";
            return output;
        }
    }
}
