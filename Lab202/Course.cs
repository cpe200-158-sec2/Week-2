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
        private string _courseID;
        private string _lectutrer;
        private int _maxStudent;
        private int _numStudent;

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public string CourseID
        {
            get { return _courseID; }
            set
            {
                if(value.Length == 6)
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
                else { Console.WriteLine(value + ": error try setting invalid CourseID!");}
                
                
            }
           
        }



        public string Lecturer
        {
            get { return _lectutrer; }
            set
            {
                _lectutrer = value;
            }
        }
        public int MaxStudent
        {
            get { return _maxStudent; }
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
            get { return _numStudent; }
            set {
                if (value >=0 && value <= MaxStudent)
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
        public Course ()
        {
            _name = "";
            _courseID = "";
            _lectutrer = "Staff";
            _maxStudent = 30;
            _numStudent = 0;
        }
        public Course (string ipName,string ipCourseID)
        {
            _name = ipName;
            _courseID = ipCourseID;
            _lectutrer = "Staff";
            _maxStudent = 30;
            _numStudent = 0;
        }
        public Course (string ipName,string ipCourseID,string ipLecturer)
        {
            _name = ipName;
            _courseID = ipCourseID;
            _lectutrer = ipLecturer;
            _maxStudent = 30;
            _numStudent = 0;
        }
        public Course(string ipName, string ipCourseID, string ipLecturer,int ipMaxStudent)
        {
            _name = ipName;
            _courseID = ipCourseID;
            _lectutrer = ipLecturer;
            _maxStudent = ipMaxStudent;
            _numStudent = 0;
        }
        public Course(string ipName, string ipCourseID, string ipLecturer, int ipMaxStudent , int ipNumStudent)
        {
            _name = ipName;
            _courseID = ipCourseID;
            _lectutrer = ipLecturer;
            _maxStudent = ipMaxStudent;
            _numStudent = ipNumStudent;
        }
        public override string ToString()
        {
            string s = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudent + " students, max=" + MaxStudent + "]";
            return s;
        }








    }
}
