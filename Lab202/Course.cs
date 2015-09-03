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
        private string _Lecturer="staff";
        private int _MaxStudents=30;
        private int _NumStudents=0;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string CourseID
        {
            get { return _CourseID; }
            set {
                string temp = value;
                if (temp.Length > 6 || !temp.All(char.IsDigit))
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                else _CourseID = value;
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
            set { if (value > 80)
                    Console.WriteLine(_CourseID+": error try setting invalid Max No. Students!");
                else
                    _MaxStudents = value; }
        }
        public int NumStudents
        {
            get { return _NumStudents; }
            set {
                if(value > _MaxStudents)
                    Console.WriteLine(_CourseID+": error try setting invalid No.Students!");
                else 
                    _NumStudents = value;
            }
        }
        public Course()
        {

        }

        public Course(string name,string courseID)
        {
            _Name = name;
            _CourseID = courseID;
        }

        public Course(string name,string courseID,string lecturer)
        {
            _Name = name;
            _CourseID = courseID;
            _Lecturer = lecturer;
        }

        public Course(string name, string courseID, string lecturer,int max)
        {
            _Name = name;
            _CourseID = courseID;
            _Lecturer = lecturer;
            _MaxStudents = max;
        }

        public override string ToString()
        {
            string output= "[Course: "+_Name+" ("+_CourseID+"), Lecturer="+_Lecturer+", has "+_NumStudents+", max="+_MaxStudents+"]";
            return output;
        }
    }
}
