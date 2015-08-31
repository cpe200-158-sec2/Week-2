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
	
	class Course{
		private string name = "Self-Access";
		private string csid = "Unknown";
		private string lecture = "staff";
		private int numStud = 0;
		private int maxStud = 30;
		//function
		public Course(){
			this.name = "Self-Access";
		}
		public Course(string name, string csid){
			this.name = name;
			this.csid = csid;
		}
		public Course(string name, string csid, string lecture){
			this.name = name;
			this.csid = csid;
			this.lecture = lecture;
		}
		public Course(string name, string csid, string lecture, int maxStud){
			this.name = name;
			this.csid = csid;
			this.lecture = lecture;
			this.maxStud = maxStud;
		}
		
		public void setName(string name){
			this.name = name;
		}
		public void setCsid(string csid){
			if(!DigitsOnly(csid)||csid.Length!=6){
				Console.WriteLine(csid+": Invalid CourseID value! (Only 6 number digits!)");
			}
			else{
				this.csid = csid;
			}			
		}
		bool DigitsOnly(string str){
			foreach (char c in str){
		    	if (c < '0' || c > '9')
		      		return false;
		  }	
		  return true;
		}
		
		public void setLecture(string lecture){
			this.lecture = lecture;
		}
		public void setMaxStud(int maxStud){
			if (maxStud < 0 || maxStud > 80 || maxStud < numStud){
				Console.WriteLine(csid+": Invalid max student value! (Only 0-80 and must be more than number of student!)");
			}
			else{ 
				this.maxStud = maxStud; 
			}
		}
		public void setNumStud(int numStud){
			if (numStud>maxStud || numStud<0){
				Console.WriteLine(csid+": Invalid number of student value! (Can't be negative or higher than max student!)");
			}
			else{ 
				this.numStud = numStud; 
			}
		}
		
		public override string ToString(){
			return "Course: ["+name+"]("+csid+"),Lecturer="+lecture+", has "+numStud+" students, max= "+ maxStud +"]";			
		}
		
	}
}
