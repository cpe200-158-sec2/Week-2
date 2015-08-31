using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _name;
        private string _studentid;
        private int _year;
        private bool _isactive;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string StudentID
        {
            get { return _studentid; }
            set { _studentid = value; }
        }
        public int YearOfBirth
        {
            get { return _year; }
            set
            {
                if (value>=1950&&value<=2000)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("57005: error try setting invalid year-of-birth value!");
                }
            }
        }
        public bool isActive
        {
            get { return _isactive; }
            set { _isactive = value; }
        }

        public Student()
        {
            _name = "John Doe";
            _studentid = "Unknown";
            _year = 1995;
            _isactive = false;
        }
        public Student(string entername,string enterstudentid)
        {
            this.Name = entername;
            this.StudentID = enterstudentid;
            _year = 1995;
            _isactive = true;
        }
        public Student(string entername, string enterstudentid,int enteryearofbirth)
        {
            this.Name = entername;
            this.StudentID = enterstudentid;
            this.YearOfBirth = enteryearofbirth;
            _isactive = true;
        }
        public Student(string entername, string enterstudentid, int enteryearofbirth,bool enterisactive)
        {
            this.Name = entername;
            this.StudentID = enterstudentid;
            this.YearOfBirth = enteryearofbirth;
            this.isActive = enterisactive;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
        public override string ToString()
        {
            string  act = "";
            if(isActive==true)
            {
                act = " is active student]";
            }
            else
            {
                act = " is NOT active student]";
            }
            string show = "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + "," + act;
            return show;
        }
    }
}
