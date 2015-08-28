using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
        public class Student
        {
            private string _Name;
            private string _id;
            private int _YearOfBirth;
            private bool _isActive;

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
            public string id
            {
                get { return _id; }
                set { _id = value; }
            }
            public int YearOfBirth
            {
                get { return _YearOfBirth; }
                set { if (value > 2000 || value < 1950) Console.WriteLine("{0}: error try setting invalid year-of-birth value!", id); else _YearOfBirth = value; }
            }
            public bool isActive
            {
                get { return _isActive; }
                set { _isActive = value; }
            }

            //constructor
            public Student()
            {
                _Name = "John Doe";
                _id = "UNKNOW";
                _YearOfBirth = 1995;
                _isActive = false;
            }

            public Student(string stdnm, string stdid)
            {
                _Name = stdnm;
                _id = stdid;
                _YearOfBirth = 1995;
                _isActive = true;
            }

            public Student(string stdnm, string stdid, int stdyob)
            {
                _Name = stdnm;
                _id = stdid;
                _YearOfBirth = stdyob;
                _isActive = true;
            }

            public Student(string stdnm, string stdid, int stdyob, bool stdst)
            {
                _Name = stdnm;
                _id = stdid;
                _YearOfBirth = stdyob;
                _isActive = stdst;
            }

            public int getAge()
            {
            int year = DateTime.Now.Year;
               return year - _YearOfBirth;
                
        }

            public override string ToString()
            {
                return string.Format("[Student: {0} ({1}), age={2}, is {3}", _Name, _id, getAge(), (_isActive) ? " is active student]" : " is NOT active student]");
            }
        }
    }

