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
        private string _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public string Name
        {
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
            set {
                    if (value > 2000 || value < 1950)
                    {
                        Console.WriteLine ("{0}: error try setting invalid year - of - birth value!", StudentID);
                    }
                    else { _YearOfBirth = value;}
                     
                }
        }
        
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 1995;
            IsActive = false;
        }
        public Student(string name,string studentID)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = 1995;
            IsActive = true;
        }
        public Student(string name, string studentID,int yearOfBirth)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = yearOfBirth;
            IsActive = true;
        }
        public Student(string name, string studentID,int yearOfBirth,bool isActive)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = yearOfBirth;
            IsActive = isActive;
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public override string ToString()
        {
           if (IsActive==true)
            {
                return string.Format ("[Student: {0}({1}), age={2} , is active student]", Name,StudentID, getAge());
            }
            else
            {
                return string.Format("[Student: {0}({1}), age={2} , is Not active student]", Name, StudentID, getAge());
            }
            
        }
                
    }
}
