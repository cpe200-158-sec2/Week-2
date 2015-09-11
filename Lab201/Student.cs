using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        private string _Name;
        private string _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public int YearOfBirth
        {
                get{ return _YearOfBirth; }
            set
            {
                if(value<=2000&&value>=1995)
                {
                    _YearOfBirth = value;
                }
                else
                {
                    Console.WriteLine(" error try setting invalid year-of-birth value!");
                }
            }       
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string StudentID
        {
            get{return _StudentID;}
            set { _StudentID = value; }
        }  
        public bool isActive     
        {
            get { return _isActive; }  
            set { _isActive = value; }
        }
        public Student()
        {
            _Name = "John Doe";
            _YearOfBirth = 1995;
            _StudentID = "Unknow";    
            _isActive = false;

        }

        public Student(string name, string number)
        {
            _Name = name;
            _StudentID = number;
            _YearOfBirth = 1995;
            _isActive = true;

        }
        public Student(string name, string number, int b)
        {
            _Name = name;
            _StudentID = number;
            _YearOfBirth = b;
            _isActive = true;
        }
        
        override public string ToString()
        {
            string output = "[Student : " + Name + "(" + StudentID + "), age =" + getAge() + " is ";
            if (isActive == true)
            {
                output = output + ("active student]");
            }
            else           
            { 
                output = output + ("NOT active student]");  
            }
            return output;
        }
        public int getAge()
        {

            return 2015 - YearOfBirth;
        }
    }


}
