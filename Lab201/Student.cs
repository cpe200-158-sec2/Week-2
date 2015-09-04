using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        //private members
        private string _name;
        private string _studentid;
        private int _yearofbirth;
        private bool _isactive;

        //public members
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

        public string StudentID
        {
            get
            {
                return _studentid;
            }
            set
            {
                _studentid = value;
            }
        }

        public int YearOfBirth
        {
            get
            { return _yearofbirth; }
            set
            {
                if (value >= 1950 && value <= 2000) // value must be between 1950 and 2000 
                    _yearofbirth = value;
            }
                else //else display error message.
                {
                Console.WriteLine("{0} :error try setting invalid year-of-birth value!", StudentID);
            }
        }

        public bool IsActive
        {
            get
            {
                return _isactive;
            }
            set
            {
                _isactive = value;
            }

        }

        //Constructor
        public Student() //Default
        {
            _name = "John Doe";
            _studentID = "Unknown";
            _year = 1995;
            _isActive = false;

        }
        public Student(string conName, string conStudentID) //Construct name + ID
        {
            this.Name = conName;
            this.StudentID = conStudentID;
            this.YearOfBirth = 1995;
            this.IsActive = true;
        }
        public Student(string conName, string conStudentID, int conYear) //Construct name + ID + Year
        {
            this.Name = conName;
            this.StudentID = conStudentID;
            this.YearOfBirth = conYear;
            this.IsActive = true;

        }
        public Student(string conName, string conStudentID, int conYear, bool conIsActive) //Construct name + ID + Year + Active?
        {
            this.Name = conName;
            this.StudentID = conStudentID;
            this.YearOfBirth = conYear;
            this.IsActive = conIsActive;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
        public override string ToString()
        {
            string isActive = "";
            if (IsActive == true)
            {
                isActive = "is active student]";
            }
            else
            {
                isActive = "is not active student]";
            }
            string show = "[Student : " + Name + "(" + StudentID + "), Age =" + getAge() + "," + isActive;
            return show;
        }
    }