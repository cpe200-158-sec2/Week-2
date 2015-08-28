using System;
namespace Lab2
{
    class Student
    {
        private string _name;
        private string _studentID;
        private int _yob;
        private bool _isActive;

        public Student()
        {
            _name = "John Doe";
            _studentID = "Unknown";
            _yob = 1995;
            _isActive = false;
        }

        public Student(string n, string id)
        {
            _name = n;
            _studentID = id;
            _yob = 1995;
            _isActive = true;
        }

        public Student(string n, string id, int yob)
        {
            _name = n;
            _studentID = id;
            this.YearOfBirth = yob;
            _isActive = true;
        }

        public Student(string n, string id, int yob, bool active)
        {
            _name = n;
            _studentID = id;
            this.YearOfBirth = yob;
            _isActive = active;
        }

        public string Name
        {
            get{ return _name; }
            set{ _name = value; }
        }

        public string ID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public int YearOfBirth
        {
            get { return _yob; }
            set
            {
                if(value<1950 || value > 2000)
                {
                    Console.WriteLine("{0}: error try setting invalid year-of-birth value!", _studentID);
                    //throw new OverflowException();
                }
                else
                {
                    _yob = value;
                }
            }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public int getAge()
        {
            return 2015-_yob;
        }

        public override string ToString()
        {
            string status = "";
            if(_isActive==false)
            {
                status = "NOT ";
            }
            string s = "[Student: "+ _name +" ("+ _studentID +"), age="+ this.getAge() +", is "+ status +"active student]";
            return s;
        }
    }
}
