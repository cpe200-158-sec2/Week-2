using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        //member 
        private string _name;
        private string _studentID;
        private int _year;
        private bool _isActive;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string StudentID
        {
            get
            { return _studentID; }
            set
            { _studentID = value; }
        }
        public int YearOfBirth
        {//from 1950 to 2000)
            get
            { return _year; }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("{0} :error try setting invalid year-of-birth value!",StudentID);
                   
                }
            }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        //Constructure
        public Student() 
        {
            _name = "John Doe";
            _studentID = "Unknown";
            _year = 1995;
            _isActive = false;

        }
        public Student( string ipName, string ipStudentID  )
        {
            this.Name = ipName;
            this.StudentID = ipStudentID;
            this.YearOfBirth = 1995;
            this.IsActive = true;
        }
        public Student(string ipName, string ipStudentID, int ipYear)
        {
            this.Name = ipName;
            this.StudentID = ipStudentID;
            this.YearOfBirth = ipYear;
            this.IsActive = true;

        }
        public Student(string ipName, string ipStudentID, int ipYear,bool ipIsActive)
        {
            this.Name = ipName;
            this.StudentID = ipStudentID;
            this.YearOfBirth = ipYear;
            this.IsActive = ipIsActive;
        }

        //method
        public int getAge()
        {
            return 2015 - YearOfBirth;
        }
        public override string ToString()
        {
            string  isActive = "" ;
            if( IsActive == true)
            {
                isActive = "is active student]";
            }
            else
            {
                isActive = "is not active student]";
            }
            string show = "[Student : " + Name + "(" + StudentID + "), Age =" + getAge() + "," + isActive ;
            return show;
        }

    }

}
