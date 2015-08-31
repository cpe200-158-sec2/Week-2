using System;

namespace Student
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Testing the Student class */
			Student[] stds = new Student[7];
			stds[0] = new Student ();
			stds[1] = new Student ("s1","57001");
			stds[2] = new Student ("s2","57002",1994);
			stds[3] = new Student ("s3","57003",1996);
			stds[4] = new Student ("s4","57004");
			stds[5] = new Student ("s5","57005",1993);
			stds[6] = new Student ("s6","57006");

			Console.WriteLine ("\n--- Initial Students' state ---");
			foreach (Student s in stds)
				Console.WriteLine (s);

			Console.WriteLine ("\n--- Playing with s4, s5, s6 objects ---");
			stds [4].setName("Mario");
			stds [5].setYob(1900);
			stds [6].setActive(false);
			for (int i = 4; i < stds.Length; i++)
				Console.WriteLine (stds [i]);
			Console.ReadLine();
		}
	}
	
	class Student{
		private string name = "John Lennon";
		private string stid = "Unknown";
		private int yob = 1995;
		private bool isActive = true;
		//function
		public Student(){
			yob = 1995;
			isActive = false;
		}
		public Student(string name, string stid){
			this.name = name;
			this.stid = stid;
		}
		public Student(string name, string stid, int yob){
			this.name = name;
			this.stid = stid;
			this.yob = yob;
		}
		public Student(string name, string stid, int yob, bool action){
			this.name = name;
			this.stid = stid;
			this.yob = yob;
			this.isActive = action;
		}
		
		public void setName(string name){
			this.name = name;
		}
		public void setStid(string stid){
			this.stid = stid;
		}
		public void setYob(int yob){
			if (yob < 1950 || yob > 2000){
				Console.WriteLine(stid+": Invalid year-of-birth value! (Only 1950-2000)");
			}
			else{ 
				this.yob = yob; 
			}
		}
		public void setActive(bool action){
			isActive = action;
		}
		public int getAge(){
			return 2015-this.yob;
		}
		
		public override string ToString(){
			if (isActive == true){
				return "Student :"+name+"("+stid+")"+"age="+getAge() +" is active student";
			}
			else{
				return "Student :"+name+"("+stid+")"+"age="+getAge() +" is not active student";
			}
		}
	}
}
