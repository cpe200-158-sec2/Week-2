using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{

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
            set
            {

                bool num = true;
                for (int i = 0; i < value.Length; i++)
                {

                    if (value[i] < '0' || value[i] > '9')
                    {
                        num = false;
                        break;
                    }

                }

                if (value.Length != 6 || num == false)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID,this.CourseID", CourseID);
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
                if (value > 0 && value <= MaxStudents)
                {
                    _NumStudents = value;
                }
                else
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!",CourseID);
                }
            }
        }

        

        public Course()
        {
            this.Name = "n";
            this.Lecture = "staff";
            this.CourseID = "0";
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string c)
        {
            this.Name = n;
            this.Lecture = "staff";
            this.CourseID = c;
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string c, string l)
        {
            this.Name = n;
            this.Lecture = l;
            this.CourseID = c;
            this.MaxStudents = 30;
            this.NumStudents = 0;
        }
        public Course(string n, string c, string l, int m)
        {
            this.Name = n;
            this.Lecture = l;
            this.CourseID = c;
            this.MaxStudents = m;
            this.NumStudents = 0;
        }
        public override string ToString()
        {

            return 
                "[Course:" + Name + "(" + CourseID + "), Lecturer="
                + Lecture + " has " + NumStudents + " students, Max=" + MaxStudents + "],";
        }

        // [Course: Object-Oriented Programming(261200), Lecturer=staff, has 0 students, max=30]
    }
}
