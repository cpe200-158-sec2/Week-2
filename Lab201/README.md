# Lab2-1 , design and implement the Student class

Creates Student class in a separate file, e.g. "Student.cs", and implements it to satisfy the following requirements:
- Properties: Name, StudentID, YearOfBirth, isActive
	Validation: YearOfBirth (from 1950 to 2000)
- Constructors:
	Student(): set default state
	Student(Name, StudentID): takes 2 parameters
	Student(Name, StudentID, YearOfBirth): takes 3 parameters
	Student(Name, StudentID, YearOfBirth, isActive): takes 4 parameters
- Methods: 
	getAge(): calculate current age of student
	ToString(): display object state in specify format (see expected output)


# Testing your class:

After you finish your "Student class", you can test your class with the provided "Program.cs" file.
The result should be similar to the output given as follows:


# Expected Output: HhHh

--- Initial Students' state ---
[Student: John Doe (Unknown), age=20, is NOT active student]
[Student: s1 (57001), age=20, is active student]
[Student: s2 (57002), age=21, is active student]
[Student: s3 (57003), age=19, is active student]
[Student: s4 (57004), age=20, is active student]
[Student: s5 (57005), age=22, is active student]
[Student: s6 (57006), age=20, is active student]

--- Playing with s4, s5, s6 objects ---
57005: error try setting invalid year-of-birth value!
[Student: Mario (57004), age=20, is active student]
[Student: s5 (57005), age=22, is active student]
[Student: s6 (57006), age=20, is NOT active student]