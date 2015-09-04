using System;

namespace Lab2
{
    class Course
    {
        private string _name;
        private string _cID;
        private string _lec;
        private int _maxStu;
        private int _numStu;
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string CourseID
        {
            get { return _cID; }
            set
            {
                if (value.Length == 6)
                {
                    bool digit=true;
                    foreach (char i in value)
                    {
                        digit = char.IsDigit(i);
                        if (digit != true)
                        {
                            Console.WriteLine(value + ": error try setting invalid CourseID!");
                            break;
                        } 
                    }
                    if (digit == true)
                    {
                        _cID = value;
                    }
                }
                else { Console.WriteLine(value + ": error try setting invalid CourseID!");}
            }
        } 

        public string Lecturer
        {
            get { return _lec; }
            set { _lec = value; }
        }

        public int MaxStudents
        {
            get { return _maxStu; }
            set
            {
                if (value>=0 && value<=80 && value >= this.NumStudents)
                {
                    _maxStu = value;
                }
                else { Console.WriteLine(CourseID + ": error try setting invalid No. Students!"); }
            }
        }

        public int NumStudents
        {
            get { return _numStu; }
            set
            {
                if(value>=0 && value <= MaxStudents)
                {
                    _numStu = value;
                }
                else
                {
                    Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                }
            }
        }

        public Course ()
        {
            _name = "";
            _cID = "";
            _lec = "Staff";
            _maxStu = 30;
            _numStu = 0;
        }

        public Course (string n, string id)
        {
            _name = n;
            _cID = id;
            _lec = "Staff";
            _maxStu = 30;
            _numStu = 0;
        }
        public Course(string n, string id,string lec)
        {
            _name = n;
            _cID = id;
            _lec = lec;
            _maxStu = 30;
            _numStu = 0;
        }
        public Course(string n, string id, string lec,int max)
        {
            _name = n;
            _cID = id;
            _lec = lec;
            _maxStu = max;
            _numStu = 0;
        }
        public Course(string n, string id, string lec, int max, int num)
        {
            _name = n;
            _cID = id;
            _lec = lec;
            _maxStu = max;
            _numStu = num;
        }
        public override string ToString()
        {
            string s = "[Course: " + Name + "(" + CourseID + "),Lecturer=" + Lecturer + ",has" + NumStudents + "students,max=" + MaxStudents + "]";
            return s;
        }
    }
}



