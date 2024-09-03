using System;

abstract class Student
{
    public string name;
    public int rollNumber;
    public int[] marks;
    
    public Student(string name, int rollNumber, int[] marks)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.marks = marks;
    }
    
    public abstract int CalculateTotalMarks();
    public abstract double CalculatePercentage();
    
    public void DisplayDetails()
    {
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Roll Number:"+ rollNumber);
    }
}

class UniversityStudent : Student
{
    public UniversityStudent(string name, int rollNumber, int[] marks) 
        : base(name, rollNumber, marks) { }
    
    // Implementing abstract methods
    public override int CalculateTotalMarks()
    {
        int total = 0;
        foreach (int mark in marks)
        {
            total += mark;
        }
        return total;
    }

    public override double CalculatePercentage()
    {
        int totalMarks = CalculateTotalMarks();
        return (totalMarks / (double)(marks.Length * 100)) * 100;
    }
    
    // Static methods
    public static string[] GetSubjectNames()
    {
        return new string[] { "C", "Python", "Java", "CSharp", "c++" };
    }

    public static int GetBacklogCount(int[] marks)
    {
        int backlogs = 0;
        foreach (int mark in marks)
        {
            if (mark < 40) {
                backlogs++;
            }
        }
        return backlogs;
    }
}

class Task1
{
    static void Main()
    {
        int[] marks = { 85, 70, 90, 40, 60 }; 
        UniversityStudent student = new UniversityStudent("Harshi", 123, marks);
        
        student.DisplayDetails();
        Console.WriteLine("Total Marks:" +student.CalculateTotalMarks());
        Console.WriteLine("Percentage:" +student.CalculatePercentage());
        
        // Calling static methods
        string[] subjects = UniversityStudent.GetSubjectNames();
        Console.WriteLine("Subjects:");
        foreach (string subject in subjects)
        {
            Console.WriteLine(subject);
        }
        
        int backlogs = UniversityStudent.GetBacklogCount(marks);
        Console.WriteLine("Backlogs: "+backlogs);
    }
}