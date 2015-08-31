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
        private string _lecturer;
        private int _maxStudents;
        private int _numStudents;

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
                return _courseID;
            }
            set
            {
                bool check = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        check = false;
                        break;
                    }
                }
                if (value.Length != 6 || check == false)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", CourseID);
                }
                else
                {
                    _courseID = value;
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
                return _maxStudents;
            }
            set
            {
                if(value<0 || value > 80 || value < this.NumStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", this.CourseID);
                }
                else
                {
                    _maxStudents = value;
                }
            }
        }
        public int NumStudents
        {
            get
            {
                return _numStudents;
            }
            set
            {
                if(value < 0 || value > this.MaxStudents)
                {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", this.CourseID);
                }
                else
                {
                    _numStudents = value;
                }
            }
        }
        public Course()
        {
            _name = "XXXXXXXXX";
            _courseID = "000000";
            _lecturer = "staff";
            _maxStudents = 30;
            _numStudents = 0;
        }
        public Course(string n, string id)
        {
            _name = n;
            _courseID = id;
            _lecturer = "staff";
            _maxStudents = 30;
            _numStudents = 0;
        }
        public Course(string n, string id, string lec)
        {
            _name = n;
            _courseID = id;
            _lecturer = lec;
            _maxStudents = 30;
            _numStudents = 0;
        }
        public Course(string n, string id, string lec, int max)
        {
            _name = n;
            _courseID = id;
            _lecturer = lec;
            _maxStudents = max;
            _numStudents = 0;
        }
        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]",_name,_courseID,_lecturer,_numStudents,_maxStudents);
        }
    }
}
