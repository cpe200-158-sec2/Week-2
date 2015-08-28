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

        public string Name { get; set; }
        public string StudentID { get; set; }
        public int YearOfBirth
        {
            get { return _YearOfBirth; }
            set {
                if (value < 1950 || value > 2000)
                    Console.WriteLine("error try setting invalid year-of-birth value!");
                else _YearOfBirth = value;
            }
        }
        public bool isActive { get; set; }

        public Student()
        {
            _Name = "John Doe";
            _StudentID = "Unknown";
            _YearOfBirth = 1995;
            _isActive = false;

        }

        public Student(string N, string ID)
        {
            _Name = N;
            _StudentID = ID;
            _YearOfBirth = 1995;
            _isActive = true;
        }

        public Student(string N, string ID, int YOB)
        {
            _Name = N;
            _StudentID = ID;
            _YearOfBirth = YOB;
            _isActive = true;
        }

        public Student(string N, string ID, int YOB, bool A)
        {
            _Name = N;
            _StudentID = ID;
            _YearOfBirth = YOB;
            _isActive = A;
        }

        public int getAge()
        {
            int thisyear = DateTime.Now.Year;
            int age = thisyear - YearOfBirth;
            return age;
        }

        public override string ToString()
        {
            string s = string.Format("[Student: {0} ({1}), age={2}, ", Name, _StudentID, getAge());
            s += (_isActive) ? "is active student]" : "is NOT active student]";
            return s;
        }
    }
}
