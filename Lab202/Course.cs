namespace Lab2
{
    internal class Course
    {
        /*- Properties: Name, CourseID, Lecturer, MaxStudents, NumStudents
	Validation: CourseID (6-digit number only), 
				NumStudents (0-MaxStudents)
				MaxStudents (0-80, and >= NumStudents)
- Constructors:
	Course(): set default state
	Course(Name, CourseID): takes 2 parameters
	Course(Name, CourseID, Lecturer): takes 3 parameters
	Course(Name, CourseID, Lecturer, MaxStudents): takes 4 parameters
- Methods: 
	ToString(): display object state in specify format (see expected output)
*/
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string courseID;
        public string CourseID
        {
            get { return courseID; }
            set
            {
                int n;
                bool isNumeric = int.TryParse(value, out n);
                if (!(value.Length != 6 || !isNumeric))
                {
                    courseID = value;
                }
                else
                {
                    System.Console.WriteLine(CourseID + ": error try setting invalid courseid!");
                    //261200: error try setting invalid courseid!
                }


            }
        }

        private string lecturer;

        public string Lecturer
        {
            get { return lecturer; }
            set { lecturer = value; }
        }
        
        //MaxStudents(0-80, and >= NumStudents)
        private int maxStudents;

        public int MaxStudents
        {
            get { return maxStudents; }
            set
            {
                if ((value >= 0 && value <= 80) && value >= NumStudents)
                    maxStudents = value;
                else
                {//261200: error try setting invalid max no.students!
                    System.Console.WriteLine(CourseID + ": error try setting invalid max no.students!");
                }
            }
        }

        private int numStudents;

        public int NumStudents
        {
            get { return numStudents; }
            set
            {
                if (value >= 0 && value <= MaxStudents)
                    numStudents = value;
                else
                {//261200: error try setting invalid courseid!
                    System.Console.WriteLine(CourseID + ": error try setting invalid no.students");
                }
            }
        }


        public Course()
        {
            Name = "-";
            CourseID = "000000";
            Lecturer = "Staff";
            MaxStudents = 30;
        }
        public Course(string name, string courseID)
        {
            Name = name;
            CourseID = courseID;
            Lecturer = "Staff";
            MaxStudents = 30;
        }
        public Course(string name, string courseID, string lecturer)
        {
            Name = name;
            CourseID = courseID;
            Lecturer = lecturer;
            MaxStudents = 30;
        }
        public Course(string name, string courseID, string lecturer, int maxStudent)
        {
            Name = name;
            CourseID = courseID;
            Lecturer = lecturer;
            MaxStudents = maxStudent;
        }
        public override string ToString()
        {
            return "Course: " + Name + " (" + CourseID + "), lecturer = " + Lecturer + ", has " + NumStudents + " students, max = " + MaxStudents;
        }
    }


    //Validation: CourseID(6-digit number only), 
    //            NumStudents(0-MaxStudents)
    //            MaxStudents(0-80, and >= NumStudents)
}
//--- initial courses state ---
//[course: object-oriented programming(261300), lecturer=staff, has 0 students, max=30]
//[course: programming language for isne(269103), lecturer=dome, has 0 students, max=30]
//[course: dip(261105), lecturer=dr.kenneth cosh, has 0 students, max=60]

//--- playing with cpe200 object ---
//[course: object-oriented programming(261200), lecturer=staff, has 0 students, max=30]
//261200: error try setting invalid courseid!
//261200: error try setting invalid courseid!
//261200: error try setting invalid no.students!
//[course: object-oriented programming(261200), lecturer=staff, has 0 students, max=30]
//[course: object-oriented programming(261200), lecturer=staff, has 0 students, max=60]
//[course: object-oriented programming(261200), lecturer=staff, has 40 students, max=60]
//261200: error try setting invalid max no.students!
//[course: object-oriented programming(261200), lecturer=staff, has 40 students, max=40]

//--- playing with cpe453 object ---
//[course: digital image processing(261453), lecturer=sansanee, has 0 students, max=20]