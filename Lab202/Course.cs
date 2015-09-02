using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _subject;
        private string _idsubject;
        private string _lecturer;
        private int _howmany;
        private int _max;


        public string Name
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public string CourseID
        {
            get { return _idsubject; }
            set
            {
                if (value.Length != 6)
                {
                    Console.WriteLine("261200: error try setting invalid CourseID!");
                }
                else
                {
                    bool b = true;
                    foreach (char a in value)
                    {
                        b = char.IsDigit(a);
                            if (b == false)
                            {
                                Console.WriteLine("261200: error try setting invalid CourseID!");
                                break;
                            }
                       
                    }
                    if(b==true)
                    {
                        _idsubject = value;
                    }
                }
            }
        }

        public string Lecturer
        {
            get { return _lecturer; }
            set { _lecturer = value; }
        }

        public int NumStudents
        {
            get { return _howmany; }
            set
            {
                if (value >= 0 && value < MaxStudents)
                {
                    _howmany = value;
                }
                else
                {
                    value = 0;
                    _howmany = value;
                    Console.WriteLine("261200: error try setting invalid No. Students!");
                }

            }
        }

        public int MaxStudents
        {
            get { return _max; }
            set
            {
                if (value > 0 && value < 80)
                {
                    if (value >= NumStudents)
                    {
                        _max = value;
                    }
                    else
                    {
                        Console.WriteLine("261200: error try setting invalid Max No. Students!");
                    }
                }
                else
                {
                    Console.WriteLine("261200: error try setting invalid Max No. Students!");
                }
            }
        }

        public Course(string su,string idsu)
        {
            this.Name = su;
            this.CourseID = idsu;
            this.Lecturer = "Staff";
            this.NumStudents = 0;
            this.MaxStudents = 30;
        }

        public Course(string su,string idsu,string lec)
        {
            this.Name = su;
            this.CourseID = idsu;
            this.Lecturer = lec;
            this.NumStudents = 0;
            this.MaxStudents = 30;
        }

        public Course(string su,string idsu, string lec,int how)
        {
            this.Name = su;
            this.CourseID = idsu;
            this.Lecturer = lec;
            this.NumStudents = how;
            this.MaxStudents = 30;   
        }

        public Course(string su,string idsu, string lec, int how, int mx)
        {
            this.Name = su;
            this.CourseID = idsu;
            this.Lecturer = lec;
            this.NumStudents = how;
            this.MaxStudents = mx;
        }

        public override string ToString()
        {
            string s =("[Course:" + Name + "(" + CourseID + "), Lecturer =" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]");
            return s;
        }

    }
}
