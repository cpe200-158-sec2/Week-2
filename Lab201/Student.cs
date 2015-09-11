using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string Name;
        private string _Student;
        private int YearOfBirth;
        private bool Active;

        public string NameID
        {
            get { return Name; }
            set { Name = value; }
        }
        public string StudentID
        {
            get { return _Student; }
            set { _Student = value; }
        }
        public int YearOfBirthID
        {
            get { return YearOfBirth; }
            set { if(value>=1950&&value<=2000) Console.WriteLine("{0}: error try setting invalid year-of-birth value!", StudentID); else YearOfBirth = value; }
        }
        public bool ActiveID
        {
            get { return Active; }
            set { Active = value; }
        }

        public Student()
        {
            Name = "john Doe";
            _Student = "Unknow";
            YearOfBirth = 1995;
            Active = false;
        }
        public Student(string stdnm,string stdid)
        {
            Name = stdnm;
            _Student = stdid;
            YearOfBirth = 1995;
            Active = true;
        }
        public Student(string stdnm,string stdid,int yob)
        {
            Name = stdnm;
            _Student = stdid;
            YearOfBirth = yob;
            Active = true;
        }
        public Student(string stdnm,string stdid,int yob,bool st)
        {
            Name = stdnm;
            _Student = stdid;
            YearOfBirth = yob;
            Active = st;
        }
        public int getage()
        {
            int year = DateTime.Now.Year;
            return year - YearOfBirth;
        }
        override public string ToString()
        {
            return string.Format("[Student: {0} ({1}), age={2}, is {3}", Name, _Student, getage(), (Active) ? " is active student]" : " is NOT active student]");
        }
    }
}
