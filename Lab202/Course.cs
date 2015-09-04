using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        //Private members
        private string _name;
        private string _courseid;
        private string _lectutrer;
        private int _maxstudent;
        private int _numstudent;

        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string CourseID
        {
            get {
                return _courseID;
            }
            set
            {
                if (value.Length == 6)
                {
                    bool digit = true;
                    foreach (char n in value)
                    {
                        digit = char.IsDigit(n);
                        if (digit != true)
                        {
                            Console.WriteLine(value + ": error try setting invalid CourseID!");
                            break;
                        }

                    }
                    if (digit == true)
                    {
                        _courseID = value;
                    }

                }
                else { Console.WriteLine(value + ": error try setting invalid CourseID!"); }
            }

        }

        public string Lecturer
        {
            get {
                return _lectutrer;
            }
            set
            {
                _lectutrer = value;
            }
        }

        public int MaxStudent
        {
            get {
                return _maxStudent;
            }
            set
            {
                if (value >= 0 && value <= 80 && value >= this.NumStudent)
                {
                    _maxStudent = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                }
            }
        }

        public int NumStudent
        {
            get {
                return _numStudent;
            }
            set
            {
                if (value >= 0 && value <= MaxStudent)
                {
                    _numStudent = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                }
            }
        }

        //constructor
        public Course() //Default
        {
            _name = "";
            _courseID = "";
            _lectutrer = "Staff";
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string conName, string conCourseID) //Construct  name + ID
        {
            _name = conName;
            _courseID = conCourseID;
            _lectutrer = "Staff";
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string conName, string conCourseID, string conLecturer)  // Construct name + ID + lecturer
        {
            _name = conName;
            _courseID = conCourseID;
            _lectutrer = conLecturer;
            _maxStudent = 30;
            _numStudent = 0;
        }

        public Course(string conName, string conCourseID, string conLecturer, int conMaxStudent)// Construct name + ID + lecturer + Max
        {
            {
            _name = conName;
            _courseID = conCourseID;
            _lectutrer = conLecturer;
            _maxStudent = conMaxStudent;
            _numStudent = 0;
        }

        public Course(string conName, string conCourseID, string conLecturer, int conMaxStudent, int conNumStudent)// Construct name + ID + lecturer + Max + Num
        {
            _name = conName;
            _courseID = conCourseID;
            _lectutrer = conLecturer;
            _maxStudent = conMaxStudent;
            _numStudent = conNumStudent;
        }

        public override string ToString()
        {
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudent + " students, max=" + MaxStudent + "]";
            return s;
        }
    }
}
