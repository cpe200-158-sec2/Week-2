using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name;
        private string courseid;
        private string lecturer;
        private int maxstudents;
        private int numstudents;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string CourseID
        {
            get { return courseid; }
            set
            {
                bool Check = true;
                foreach (char c in value)
                {
                    if (!Char.IsDigit(c))
                    {
                        Check = false;
                    }
                }
                if (Check == false || value.Length > 6)
                {
                    Console.WriteLine(courseid + "error try setting invalid CourseID!");
                }
                else
                {
                    courseid = value;
                }

            }
        }
        public string Lecturer
        {
            get { return lecturer; }
            set { lecturer = value; }
        }
        public int MaxStudents
        {
            get { return maxstudents; }
            set
            {
                if (numstudents > value)
                {
                    Console.WriteLine(courseid + ": error try setting invalid Max No. Students!");
                }
                else
                {
                    maxstudents = value;
                }
            }
        }
        public int NumStudents
        {
            get { return numstudents; }
            set
            {
                if (value <= maxstudents)
                {
                    numstudents = value;
                }
                else
                {
                    Console.WriteLine(courseid + ": error try setting invalid Max No. Students!");
                }
            }
        }
        public Course()
        {
            name = "Otis";
            courseid = "XXXX";
            lecturer = "Staff";
            maxstudents = 30;
            numstudents = 0;
        }
        public Course(string name, string ID)
        {
            Name = name;
            CourseID = ID;
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name, string ID, string lecture)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecture;
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name, string ID, string lecture, int max)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecture;
            MaxStudents = max;
            NumStudents = 0;
        }
        override public string ToString()
        {
            string output = "[Course: " + name + " (" + courseid + "), Lecturer=" + lecturer + ", has " + numstudents + " students, max=" + maxstudents + "]";
            return output;
        }
    }
}
