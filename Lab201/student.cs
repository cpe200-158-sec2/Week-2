using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        public string Name;
        public string StudentID;
        private int y;
        public int YearOfBirth
        {

            get { return y; }
            set {
                if (value >= 1950 && value <= 2000)
                {
                    y = value;

                }
                else
                {
                    Console.WriteLine("57005: error try setting invalid year-of-birth value!");
                }
            }
 
        }
        public bool isActive;


        public Student()
        {
            Name = "John Doe";
            StudentID = "Unknown";
            YearOfBirth = 1995;
            isActive = false;
        }

        public Student(string n, string i)
        {
            Name = n;
            StudentID = i;
            YearOfBirth = 1995;
            isActive = true;
        }
        public Student(string n, string i,int y)
        {
            Name = n;
            StudentID = i;
            YearOfBirth = y;
            isActive = true;
        }
        public Student(string n, string i, int y,bool x)
        {
            Name = n;
            StudentID = i;
            YearOfBirth = y ;
            isActive = x;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string n)
        {
            this.Name = n;
        }
        public string getStudentID()
        {
            return StudentID;
        }
        public void setStudentID(string i)
        {
            this.StudentID = i;
        }
        public int getYearOfBirth()
        {
            return YearOfBirth;
        }

        public void setYearOfBirth(int x)
        {
            this.YearOfBirth = x;
        }
       public int  getAge()
        {
              return DateTime.Now.Year - YearOfBirth;
 
        }
       public override string ToString()
       {
           
           string ac;
           if(isActive == true)
           {
               ac = " is active student";
                  
           }
           else
           {

               ac =" is NOT active student";
           }
           return string.Format("[Student : {0} ({1}), age = {2},{3}]",Name,StudentID,getAge(),ac);
       }
       



    }
}
