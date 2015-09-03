using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    //  Creates Course class in a separate file, e.g. "Course.cs", and implements it to satisfy the following requirements:
    //- Properties: Name, CourseID, Lecturer, MaxStudents, NumStudents
    //   Validation: CourseID(6-digit number only), 
    //           NumStudents(0-MaxStudents)
    //             MaxStudents(0-80, and >= NumStudents)
    class Course
    {
        private string _Name;
        private string _Lecture;
        private string _CourseID;
        private int _MaxStudents;
        private int _NumStudents;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Lecture
        {
            get { return _Lecture; }
            set { _Lecture = value; }
        }
        public string CourseID
        {
            
            get { return _CourseID; }
            set { int i = 0;
                while (i < value.Length) {
                    if (value[i] < 48 || value[i] > 57)
                    {
                        Console.WriteLine("{0},error try setting invalid CourseID,this.CourseID");
                    }
                    break;
                }
                i++;
                if (value.Length != 6)
                {
                    Console.WriteLine("{0},eror try setting invalid CourseID,this.CourseID");
                }
                else
                {
                    _CourseID = value;
                }
            }
        }
        public int MaxStudents
        {
            get { return _MaxStudents; }
            set
            {
                if (value >= 0 && value >= NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.Write("30");
                }
            }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set
            {
                if (value > 0 && value <= 80 && value <= MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.Write("0");
                }
            }
        }

       // [Course: Programming Language for ISNE(269103), Lecturer=DOME, has 0 students, max=30]

        public Course()
        {
            this.Name = "";
            this.Lecture = "staff";
            this.CourseID = "0";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course (string n,string c)
        {
            this.Name = "n";
            this.Lecture = "staff";
            this.CourseID = "c";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course (string n,string c,string l)
        {
            this.Name = "n";
            this.Lecture = "l";
            this.CourseID = "c";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course (string n, string c,string l,int m)
        {
            this.Name = "n";
            this.Lecture = "l";
            this.CourseID = "c";
            this.MaxStudents = m;
            this.NumStudents = 0;
        }
        public override string ToString()
        {
            return "[Course:" + Name + "(" + CourseID + "), Lecturer=" 
                + Lecture + "has " + NumStudents + " students, Max=" + MaxStudents + "]"; 
        }

       // [Course: Object-Oriented Programming(261200), Lecturer=staff, has 0 students, max=30]
    }
}
