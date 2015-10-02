using System;

namespace Course
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Course class */
			Course cpe200 = new Course ("Object-Oriented Programming", "261300");
			Course isne103 = new Course ("Programming Language for ISNE", "269103", "DOME");
			Course cpe453 = new Course ("DIP", "261105", "Dr. Kenneth Cosh", 60);

			Console.WriteLine ("\n--- Initial Courses state ---");
			Console.WriteLine (cpe200);
			Console.WriteLine (isne103);
			Console.WriteLine (cpe453);

			/* playing with cpe200 object */
			Console.WriteLine ("\n--- playing with cpe200 object ---");
			cpe200.setCsid("261200");
			Console.WriteLine (cpe200);
			cpe200.setCsid("2612OO");
			cpe200.setCsid("2612002");

			cpe200.setNumStud(40);
			Console.WriteLine (cpe200);
			cpe200.setMaxStud(60);
			Console.WriteLine (cpe200);
			cpe200.setNumStud(40);
			Console.WriteLine (cpe200);
			cpe200.setMaxStud(35);
			cpe200.setMaxStud(40);
			Console.WriteLine (cpe200);

			/* playing with cpe453 object */
			Console.WriteLine ("\n--- playing with cpe453 object ---");
			cpe453.setName("Digital Image Processing");
			cpe453.setCsid("261453");
			cpe453.setLecture("Sansanee");
			cpe453.setMaxStud(20);
			Console.WriteLine (cpe453);
			Console.ReadLine();
		}
	}
}
