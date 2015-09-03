using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _name;
        private string _courseid;
        private string _lecturer;
        private int _max;
        private int _num;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string CourseID
        {
            get { return _courseid; }
            set
            {
                if(value.Length == 6)
                {
                    bool number = true;
                    foreach (char d in value)
                    {
                        number = char.IsDigit(d);
                        if(number != true)
                        {
                            Console.WriteLine(value + ": error try setting invalid CourseID!");
                            break;
                        }
                    }
                    if(number == true)
                    {
                        _courseid = value;
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
            get { return _lecturer; }
            set { _lecturer = value; }
        }
        public int MaxStudents
        {
            get { return _max; }
            set
            {
                if(value >= 0 && value <= 80 && value >= this.NumStudents)
                {
                    _max = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!");
                }
            }
        }
        public int NumStudents
        {
            get { return _num; }
            set
            {
                if(value >=0 && value <= MaxStudents)
                {
                    _num = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                }
            }
        }

        public Course()
        {
            _name = "";
            _courseid = "";
            _lecturer = "staff";
            _max = 30;
            _num = 0;
        }
        public Course(string entername,string entercourseid )
        {
            this.Name = entername;
            this.CourseID = entercourseid;
            _lecturer = "staff";
            _max = 30;
            _num = 0;
        }
        public Course(string entername, string entercourseid,string enterlecturer)
        {
            this.Name = entername;
            this.CourseID = entercourseid;
            this.Lecturer = enterlecturer;
            _max = 30;
            _num = 0;
        }
        public Course(string entername, string entercourseid, string enterlecturer,int entermaxstudents)
        {
            this.Name = entername;
            this.CourseID = entercourseid;
            this.Lecturer = enterlecturer;
            this.MaxStudents = entermaxstudents;
            _num = 0;
        }

        public override string ToString()
        {
            string show = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
            return show;
        }
    }
}
