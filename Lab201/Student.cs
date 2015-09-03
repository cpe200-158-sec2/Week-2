using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string id;

        public string StudentID
        {
            get { return id; }
            set { id = value; }
        }

        private int yob;

        public int YearOfBirth
        {
            get { return yob; }
            set
            {
                if (value > 2000 || value < 1950)
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", id);
                else yob = value;
            }

        }

        private bool status;

        public bool isActive
        {
            get { return status; }
            set { status = value; }
        }


        public Student()
        {
           Name = "John Doe";
           StudentID = "UNKNOW";
           YearOfBirth = 1995;
           isActive = false;
        }

        public Student(string _name , string _id)
        {
            Name = _name;
            StudentID = _id;
            YearOfBirth = 1995;
            isActive = true;
        }

        public Student(String _name , string _id , int _yob)
        {
            Name = _name;
            StudentID = _id;
            YearOfBirth = _yob;
            isActive = true;
        }

        public Student(String _name, string _id, int _yob, bool _status)
        {
            Name = _name;
            StudentID = _id;
            YearOfBirth = _yob;
            isActive = _status;
        }



        public int getAge()
        {
            return DateTime.Now.Year - yob;
        }

        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), age ={2}, is {3} ", Name, StudentID, getAge(), (isActive) ? " is active student]" : " is NOT active student]");
        }


    }
}
