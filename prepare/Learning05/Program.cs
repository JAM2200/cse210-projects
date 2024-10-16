using System;

class Program
{
    static void Main(string[] args)
    {
	   // MathAssignment math = new mathAssignment();
	   Assignment assignment1 = new Assignment("Jane Pocket","English");
	   
	

//	   Console.WriteLine($"{assignment1.GetStudentName()}, {assignment1.GetTopic()}");

	    
	   Console.WriteLine($"{assignment1.GetSummary()}");
	   
	   MathAssignment math = new MathAssignment("Oliver Twist","Math","1-10","1.0");
	   
	   Console.WriteLine($"{math.GetSummary()}");
	   Console.WriteLine($"{math.GetHomeworkList()}");
	   
	  WritingAssignment writingAssignment = new WritingAssignment("David Guttertrack","English 301","Technical Analysis"); 

	  Console.WriteLine(writingAssignment.GetSummary());
	  Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}
