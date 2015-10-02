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
