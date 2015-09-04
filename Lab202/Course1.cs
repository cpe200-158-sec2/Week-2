using System;

namespace Lab2
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _Maxstudents;
        private int _Numstudents;

        public string Name
{
			get;
			set;
		}
		public string CourseID
{
			get { return _CourseID; }
			set
    {
        int n;
                       if (value.Length == 6 && int.TryParse(value, out n))
                    _CourseID = value;
                      else {
            Console.WriteLine(CourseID + ": error try setting invalid CourseID!");
                           }
                  }
		}
		public string Lecturer
{
			get;
			set;
		}
		public int MaxStudents
{
			get { return _Maxstudents; }
			set
    {
                       if (value > 0 && value <= 80 && value >= _Numstudents)
        {
                    _Maxstudents = value;
                           }
        else
        {
            Console.WriteLine(CourseID + ": error try setting invalid Max No. Students!");
                           }
                   }
		}
		public int NumStudents
        { 
			get { return _Numstudents; }
			set
    {
                       if (value >= 0 && value <= _Maxstudents)
        {
                    _Numstudents = value;
                           }
        else
        {
            Console.WriteLine(CourseID + ": error try setting invalid No. Students!");
                           }
                   }
	}

		private void initData()
{
    Name = "";
    CourseID = "00000";
    Lecturer = "staff";
    MaxStudents = 30;
    NumStudents = 0;
           }

		public Course()
		{
			initData();
		}

		public Course(string n, string id)
{
    initData();
    Name = n;
    CourseID = id;
           }

		public Course(string n, string id, string t)
{
    initData();
    Name = n;
    CourseID = id;
    Lecturer = t;
           }

		public Course(string n, string id, string t, int m)
{
    initData();
    Name = n;
    CourseID = id;
    Lecturer = t;
    MaxStudents = m;
           }

		public override string ToString()
		{
			return string.Format("[Course: {0} ({1}), Lecturer={2}, has {4} students, max={3}]", Name, CourseID, Lecturer, MaxStudents, NumStudents);
		}
	}
}
