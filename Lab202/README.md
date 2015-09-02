# Lab2-2 , design and implement the Course class

Creates Course class in a separate file, e.g. "Course.cs", and implements it to satisfy the following requirements:
- Properties: Name, CourseID, Lecturer, MaxStudents, NumStudents
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


# Testing your class:

After you finish your "Course class", you can test your class with the provided "Program.cs" file.
The result should be similar to the output given as follows:


# Expected Output:

--- Initial Courses state ---
[Course: Object-Oriented Programming (261300), Lecturer=staff, has 0 students, max=30]
[Course: Programming Language for ISNE (269103), Lecturer=DOME, has 0 students, max=30]
[Course: DIP (261105), Lecturer=Dr. Kenneth Cosh, has 0 students, max=60]

--- playing with cpe200 object ---
[Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=30]
261200: error try setting invalid CourseID!
261200: error try setting invalid CourseID!
261200: error try setting invalid No. Students!

[Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=30]
[Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=60]
[Course: Object-Oriented Programming (261200), Lecturer=staff, has 40 students, max=60]
261200: error try setting invalid Max No. Students!
[Course: Object-Oriented Programming (261200), Lecturer=staff, has 40 students, max=40]

--- playing with cpe453 object ---
[Course: Digital Image Processing (261453), Lecturer=Sansanee, has 0 students, max=20]
