using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Course
    {
        private string _name;
        private string _courseid;
        private string _lecturer;
        private int _max;
        private int _num;

        public Course()
        {
            _name = "Unknown";
            _courseid="xxxxxx";
            _lecturer = "staff";
            _num = 0;
            _max = 30;
        }

        public Course(string Name, string CourseID)
        {
            _name = Name;
            _courseid = CourseID;
            _lecturer = "staff";
            _num = 0;
            _max = 30;
        }

        public Course(string Name, string CourseID, string Lecturer)
        {
            _name = Name;
            _courseid = CourseID;
            _lecturer = Lecturer;
            _num = 0;
            _max = 30;

        }
        public Course(string Name,string CourseID,string Lecturer,int Maxstudents)
        {
            _name = Name;
            _courseid = CourseID;
            _lecturer = Lecturer;
            _num = 0;
            _max = Maxstudents;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string CourseID
        {
            get
            {
                return _courseid;
            }
            set
            {
                bool numb = true;
                for (int i = 0; i < 6; i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        numb = false;
                        break;
                    }

                }
            
                if (value.Length != 6 || numb==false)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", _courseid);
                }
                else
                {
                    _courseid = value;
                }

            }
        }
        public string Lecturer
        {
            get
            {
                return _lecturer;
            }
            set
            {
                _lecturer = value;
            }
        }

        public int MaxStudents
        {
            get
            {
                return _max;
            }
            set
            {
                if (value < 0 || value > 80 || value < _num)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", _courseid);
                }
                else
                {
                    _max = value;
                } 
            }
        }

        public int NumStudents
        {
            get
            {
                return _num;

            }
            set
            {
                if(value<0 || value > _max)
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", _courseid);
                }
                else
                {
                    _num = value;
                }
            }
        }

        public override string ToString()
        {
            string st;
            st = "[Course:" + _name + "(" + _courseid + "), Lecturer=" + _lecturer + ", has " + _num + " students, max = " + _max + "]" ;
            return st;
        }
        
        
    }
}
