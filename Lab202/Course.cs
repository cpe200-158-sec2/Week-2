using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        private string id;

        public string CourseID
        {
            get { return id; }
            set
            {
                if (value.Length == 6)
                {
                    bool checker = true;
                    foreach (char n in value)
                    {
                        checker = char.IsDigit(n);
                        if (checker == false)
                        {
                            Console.WriteLine(value + ": error try setting invalid CourseID!");
                            break;
                        }
                    }
                    if (checker == true)
                    {
                        id = value;
                    }
                }
                else { Console.WriteLine(value + ": error try setting invalid CourseID!"); }
            }
        }

        private string lec;

        public string Lecturer
        {
            get { return lec; }
            set { lec = value; }
        }

        private int max;

        public int MaxStudents
        {
            get { return max; }
            set
            {
                if (value < 0 || value < number || value > 80)
                    Console.WriteLine(id + ": error try setting invalid No. Students!");

                else max = value;
            }
        }


        private int number;

        public int NumStudents
        {
            get { return number; }
            set
            {
                if (value < 0 || value > max)
                    Console.WriteLine(id + ": error try setting invalid No. Students!");

                else number = value;
            }
        }


        public Course()
        {
            Name = "";
            CourseID = "";
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }

        public Course(string _name, string _id)
        {
            Name = _name;
            CourseID = _id;
            Lecturer = "Staff";
            MaxStudents = 30;
            NumStudents = 0;
        }

        public Course(string _name, string _id, string _lec)
        {
            Name = _name;
            CourseID = _id;
            Lecturer = _lec;
            MaxStudents = 30;
            NumStudents = 0;
        }

        public Course(string _name, string _id, string _lec, int _max)
        {
            Name = _name;
            CourseID = _id;
            Lecturer = _lec;
            MaxStudents = _max;
            NumStudents = 0;
        }

        public Course(string _name, string _id, string _lec, int _max, int _num)
        {
            Name = _name;
            CourseID = _id;
            Lecturer = _lec;
            MaxStudents = _max;
            NumStudents = _num;
        }

        public override string ToString()
        {
            return string.Format("[Course: {0} ({1}), Lecturer={2}, has {3} students, max={4}]", name, id, lec, number, max);
        }
    }
}
