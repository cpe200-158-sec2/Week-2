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
           
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int years
        {
            get{return _year;}
            set
            {
                if (value< 1950 || value> 2000)
                {
                    //throw new OverflowException();
                    Console.WriteLine( studentid  + " : error try setting invalid year-of-birth value!");
                }
                else
                {
                    _year = value;
                }         
            }
        }

        public string studentid
        {
            get { return _studentid; }
            set { _studentid = value; }
        }

        public bool isactive
        {
            get { return _isactive; }
            set { _isactive = value; }
        }

        public Student()
        {
            this.name = "John Dee";
            this.studentid = "Unknown";
            this.years = 1995;
            this.isactive = false;
        }

        public Student(string na, string id)
        {
            this.name = na;
            this.studentid = id;
            this.years = 1995;
            this.isactive = true;
        }

        public Student(string na, string id, int ye)
        {
            this.name = na;
            this.studentid = id;
            this.years = ye;
            this.isactive = true;
        }

        public Student(string na, string id, int ye, bool act)
        {
            this.name = na;
            this.studentid = id;
            this.years = ye;
            this.isactive = act;
        }

        public int getage()
        {
            return 2015 - years;
        }

        public override string ToString()
        {
            string active = " ";
            if(isactive==true)
            {
                active = "Active";
            }
            else
            {
                active = "Not Active";
            }
            string s = "[Student: " + name + "(" + studentid + "), age = " + getage() + ", is " + active + " student]";
            return s;
        }          
    }
}
