using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string _lecturer = "staff";
        private string _name = "Unknow";
        private string _courseID = "Unknow";
        private int _maxStudents = 30;
        private int _numStudents = 0;

        public Course()
        {

        }
        public Course(string name, string courseID)
        {
            Name = name;
            CourseID = courseID;
        }
        public Course(string name, string courseID, string lecturer)
        {
            Lecturer = lecturer;
            Name = name;
            CourseID = courseID;
        }
        public Course(string name, string courseID, string lecturer, int maxStudent)
        {
            Lecturer = lecturer;
            Name = name;
            CourseID = courseID;
            MaxStudents = maxStudent;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public string CourseID
        {
            get { return _courseID; }
            set
            {
                if (value.Length != 6) Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID);
                else
                {
                    int i;
                    for (i = 0; i < 6; i++)
                    {
                        if (!char.IsNumber(value[i]))
                        {
                            break;
                        }
                    }
                    if (i < 6) Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID);
                    else _courseID = value;
                }

            }
        }
        public string Lecturer
        {
            get { return _lecturer; }
            set
            {
                _lecturer = value;
            }
        }
        public int NumStudents
        {
            get { return _numStudents; }
            set
            {
                if (value > MaxStudents || value < 0)
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID);
                }
                else _numStudents = value;
            }
        }
        public int MaxStudents
        {
            get { return _maxStudents; }
            set
            {
                if (value < NumStudents || value > 80 || value < 0)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
                }
                else _maxStudents = value;
            }
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", Name, CourseID, Lecturer, NumStudents, MaxStudents);
        }
    }
}
