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
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudent;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string CourseID
        {
            get { return _CourseID; }
            set
            {
                bool num = true;
                for (int i=0 ; i <value.Length; i++)
                    {
                        if(value[i] < '0' || value[i] >'9')
                        {
                            num = false;
                        break;
                           
                        }
                    }

                if (value.Length != 6 || num == false)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID! ", _CourseID); 
                                       
                }
                else {_CourseID = value; }
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
            set
            {
                if(value >=0 && value <=80 && value >= _NumStudent)
                {
                    _MaxStudents = value;
                }
                else { Console.WriteLine("{0}: error try setting invalid Max No. Students!", _CourseID); }
            }
        }
        public int NumStudents
        {
            get { return _NumStudent; }
            set
            {
                if (value >= 0 && value <= _MaxStudents)
                {
                    _NumStudent = value;
                }
                else { Console.WriteLine("{0}: error try setting invalid No. Students!", _CourseID); }
            }
        }

        public Course()
        {
            Name = "Unknown";
            CourseID = "000000";
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name,string ID)
        {
            Name = name;
            CourseID = ID;
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name,string ID ,string lecturer)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecturer;
            MaxStudents = 30;
            NumStudents = 0;
        }
        public Course(string name, string ID, string lecturer,int max)
        {
            Name = name;
            CourseID = ID;
            Lecturer = lecturer;
            MaxStudents = max;
            NumStudents = 0;
        }
        public override string ToString()
        {
              return string.Format("[Course: {0}({1}), Lecturer={2} , has {3} students ,max = {4}]", Name, CourseID, Lecturer,NumStudents,MaxStudents);
        }


    }
}
