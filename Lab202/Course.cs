using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public string Name { get; set; }
        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                bool check = true;
                foreach (char c in value)
                {
                    if (!Char.IsDigit(c))
                        check = false;
                }
                if (value.Length != 6 || check == false) Console.WriteLine("{0}: error try setting invalid CourseID!", _CourseID); else _CourseID = value;
            }
        }
        public string Lecturer { get; set; }
        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {
                if (value < _NumStudents||value>80||value<0) Console.WriteLine("{0}: error try setting invalid Max No. Students!", _CourseID);
                else _MaxStudents = value;
            }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set { if (value > _MaxStudents||value<0) Console.WriteLine("{0}: error try setting invalid No. Students!", _CourseID); else _NumStudents = value; }
        }
        public Course()
            {
                _Name = "Unknow";
                _CourseID = "Unknow";
                _Lecturer = "staff";
                _MaxStudents = 30;
                _NumStudents = 0;
            }
        public Course(string coursename, string courseid)
        {
            _Name = coursename;
            _CourseID = courseid;
            _Lecturer = "staff";
            _MaxStudents = 30;
        }
        public Course(string coursename,string courseid,string lec)
        {
            _Name = coursename;
            _CourseID = courseid;
            _Lecturer = lec;
            _MaxStudents = 30;
        }
        public Course(string coursename,string courseid ,string lec,int maxs)
        {
            _Name = coursename;
            _CourseID = CourseID;
            _Lecturer = lec;
            _MaxStudents = maxs;
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}", _Name, _CourseID, _Lecturer, _NumStudents, _MaxStudents);
        }
    }
}
