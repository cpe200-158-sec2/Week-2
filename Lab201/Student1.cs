using System;

namespace Lab2
{
    class Student
    {
        private string _name;
        private int _yearofbirth;
        private string _studentid;
        private bool _isActive;
        internal bool isActive;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int yearofBirth
        {
            get { return _yearofbirth; }
            set
            {
                if (value < 1950 || value > 2000)
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", _studentid);
                else
                    _yearofbirth = value;
            }
        }
        public string Studentid
        {
            get { return _studentid; }
            set { _studentid = value; }
        }
        public bool Isactive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public int YearOfBirth { get; internal set; }

        public Student()
        {
            _name = "John Doe";
            _yearofbirth = 1995;
            _studentid = "unknown";
            _isActive = false;
        }
        public Student(string n, string id)
        {
            _name = n;
            _studentid = id;
            _yearofbirth = 1995;
            _isActive = true;

        }
        public Student(string n, string id, int yob)
        {
            _name = n;
            _studentid = id;
            _yearofbirth = yob;
            _isActive = true;
        }
        public Student(string n, string id, int yob, bool active)
        {
            _name = n;
            _studentid = id;
            _yearofbirth = yob;
            _isActive = active;
        }
        public int getAge()
        {
            int age = 2015 - _yearofbirth;
            return age;
        }
        public override string ToString()
        {
            return string.Format("[Student: {0} ({1}), {2}, {3}", _name, _studentid, getAge(), (_isActive) ? "is active student]" : "is NOT active student]");
        }

    }
}
