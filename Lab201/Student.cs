using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private int yearOfBirth;

        public int YearOfBirth
        {
            get {

                return yearOfBirth;
            }
            set { yearOfBirth = AgeValidation(value); }
        }

        public bool isActive;
        
        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 2015 - 20;
            isActive = false;
        }
        public Student(string name, string studentID)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = 2015 - 20;
            isActive = true;
        }
        public Student(string name, string studentID, int yearOfbirth)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = AgeValidation(yearOfbirth);
            isActive = true;
        }
        public Student(string name, string studentID, int yearOfBirth, bool isActive)
        {
            Name = name;
            StudentID = studentID;
            YearOfBirth = AgeValidation(yearOfBirth);
            isActive = this.isActive;
        }
        public int getAge()
        {
            return (int)(DateTime.Now.Year - YearOfBirth);
        }

        public override string ToString()
        {
            return "[Student: " + Name + "(" + StudentID + "), age = " + getAge() + ", is "+ (!isActive?" NOT ":"") + "active student]";
        }

        private int AgeValidation(int yearOfBirth)
        {
            if (yearOfBirth <= 1950 || yearOfBirth >= 2000)
            {
                Console.WriteLine(StudentID + ": error try setting invalid year-of-birth value!");
                return YearOfBirth;
            }
            return yearOfBirth;
            
        }
    }
}
