using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
       private string _Name= "John Doe";
       private string _StudentID ="Unknown";
       private int _YearOfBirth = 1995;
       private bool _isActive = true;

        public string Name {
            get { return _Name; }
            set { _Name = value; }
        }
        public string StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }
        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set
            {
                if (value > 2000 || value < 1950)
                    Console.WriteLine(_StudentID+": error try setting invalid year-of-birth value!");
                else
                 _YearOfBirth = value;
            }
        }
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        
        public Student()
        {
            _isActive = false;
        }
        public Student(string name, string id) {
            this._Name = name;
            this._StudentID = id;
        }
        public Student(string name, string id, int year) {
            this._Name = name;
            this._StudentID = id;
            this._YearOfBirth = year;
        }
        public Student(string name, string id, int year, bool isActive) {
            this._Name = name;
            this._StudentID = id;
            this._YearOfBirth = year;
            this._isActive = isActive;
        }

       // int getAge() { }
        override public string ToString()
        {
            string output = "[Student : "+_Name+"(" + _StudentID + ")" + ", age=" +getAge()+ ", is "; 
            
            if (_isActive) output += "active student]";
            else output += "NOT active student]";
            // [Student: s1(57001), age=20, is active student]
            return output;   
        }
        private int getAge()
        {
            return 2015 - _YearOfBirth;
        }
    }
}/*
- Properties: Name, StudentID, YearOfBirth, isActive
    Validation: YearOfBirth(from 1950 to 2000)
- Constructors:
    Student(): set default state
    Student(Name, StudentID): takes 2 parameters
    Student(Name, StudentID, YearOfBirth): takes 3 parameters
    Student(Name, StudentID, YearOfBirth, isActive): takes 4 parameters
- Methods: 
    getAge(): calculate current age of student
    ToString(): display object state in specify format(see expected output)
    */