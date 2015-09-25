
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        //Properties
        private string Name;
        private string CourseID;
        private string Lecturer;
        private int MaxStudents;
        private int NumStudents;

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public string _CourseID //CourseID (6-digit number only)            
        {
            get { return CourseID; }
            set
            {
                bool check = true;
                foreach (char idCourse in _CourseID)
                {
                    if (!Char.IsDigit(idCourse))
                        check = false;
                }
                if (value.Length != 6 || check == true) Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID);
                else CourseID = value;
            }
        }

        public string _Lecturer
        {
            get { return _Lecturer; }
            set { Lecturer = value; }
        }

        public int _MaxStudents //MaxStudents(0-80, and >= NumStudents)
        {
            get { return MaxStudents; }
            set
            {
                if (value < NumStudents)
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", CourseID);
                else MaxStudents = value;
            }
        }

        public int _NumStudents //NumStudents(0-MaxStudents)
        {
            get { return NumStudents; }
            set
            {
                if (value > MaxStudents)
                    Console.WriteLine("{0}: error try setting invalid No. Students!", CourseID);
                else NumStudents = value;
            }
        }


        //Constructors
        //Course() : set default state
        public Course()
        {
            Name = "Unknow";
            CourseID = "Unknow";
            Lecturer = "staff";
            MaxStudents = 30;
        }
        //Course(Name, CourseID): takes 2 parameters
        public Course(string n, string cid)
        {
            Name = n;
            CourseID = cid;
            Lecturer = "Staff";
            MaxStudents = 30;
        }

        //Course(Name, CourseID, Lecturer): takes 3 parameters
        public Course(string n, string cid, string lec)
        {
            Name = n;
            CourseID = cid;
            Lecturer = lec;
            MaxStudents = 30;
        }
        //Course(Name, CourseID, Lecturer, MaxStudents): takes 4 parameters
        public Course(string n, string cid, string lec, int maxs)
        {
            Name = n;
            CourseID = cid;
            Lecturer = lec;
            MaxStudents = maxs;
        }

        //Methods
        //ToString(): display object state in specify format (see expected output)
        public override string ToString()
        {
            //[Course: Object-Oriented Programming (261300), Lecturer=staff, has 0 students, max=30]
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", Name, CourseID, Lecturer, NumStudents, MaxStudents);
        }
    }
}