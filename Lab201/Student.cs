using System;

public class Student
{

    public string Name;
    string StdID;
    public int YearOfBirth = 1995;
    public bool isActive = true;

    public Student()
    {
        this.Name = "John Smith";
        this.StdID = "N/A";
        this.isActive = false;
    }

    public Student(string _Name, string _StdID)
    {
        this.Name = _Name;
        this.StdID = _StdID;
    }

    public Student(string _Name, string _StdID, int _YearOfBirth)
    {
        this.Name = _Name;
        this.StdID = _StdID;
        this.YearOfBirth = ChangeBirthYear(_YearOfBirth);
    }

    public Student(string _Name, string _StdID, int _YearOfBirth, bool _isActive)
    {
        this.Name = _Name;
        this.StdID = _StdID;
        this.YearOfBirth = ChangeBirthYear(_YearOfBirth);
        this.isActive = _isActive;
    }

    public int ChangeBirthYear(int _Year)
    {
        if (1950 < _Year && _Year < 2000)
        {
            return _Year;
        }
        else
        {
            Console.WriteLine(StdID + ": Error! Trying to input invalid Year of Birth. Value reset to default(1950)");
            return 1950;
        }
    }

    public int GetAge(Student _s)
    {
        return 2015 - (_s.YearOfBirth);
    }

    public override string ToString()
    {
        string status;

        if (isActive == true)
        {
            status = "";
        }
        else
            status = "not";

        string output = "[Student: " + Name + "(" + StdID + ") , Age : " + GetAge(this) + ", is " + status + " active student.]";
        //[Student: John Doe (Unknown), age=20, is NOT active student]
        return output;
    }
}
