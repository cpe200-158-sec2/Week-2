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
        private int _yearofbirth;
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
            get { return _yearofbirth; }
            set
            {
                if (value < 1950 || value > 2000)
                {
                    Console.WriteLine("{0} : error try setting invalid year-of-birth value!", StudentID);
                    //throw new OverflowException() ;
                }
                else
                {
                    _yearofbirth = value;
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
            this.Name = "John Doe";
            this.StudentID = "Unknown";
            this.YearOfBirth = 1995;
            this.isActive = false;
        }

        public Student(string N, string ID)
        {
            this.Name = N;
            this.StudentID = ID;
            this.YearOfBirth = 1995;
            this.isActive = true;
        }

        public Student(string N, string ID, int Y)
        {
            this.Name = N;
            this.StudentID = ID;
            this.YearOfBirth = Y;
            this.isActive = true;
        }

        public Student(string N, string ID, int Y, bool act)
        {
            this.Name = N;
            this.StudentID = ID;
            this.YearOfBirth = Y;
            this.isActive = act;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public override string ToString()
        {
            string active = " ";
            if (isActive==true )
            {
                active = "active";
            }
            else
            {
                active = "NOT active";
            }
            string s = "[Student: " + Name + " ("+ StudentID  +"), age="+ getAge()  +", is " + active + " student]";
            return s;
        }

    }
}
