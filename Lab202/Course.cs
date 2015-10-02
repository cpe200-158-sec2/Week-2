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
