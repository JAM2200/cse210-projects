using System;

class Program
{
	// Start the program.
    static void Main(string[] args)
    {
	    // Create an instance of the assignment class to test its functionality.
	   Assignment assignment1 = new Assignment("Jane Pocket","English");
	   
	

//	   Console.WriteLine($"{assignment1.GetStudentName()}, {assignment1.GetTopic()}");

	    
	   Console.WriteLine($"{assignment1.GetSummary()}");
	   
	   // Create a math assignment class.
	   MathAssignment math = new MathAssignment("Oliver Twist","Math","1-10","1.0");
	   
	   // Print out the summary of the class and the assignment.
	   Console.WriteLine($"{math.GetSummary()}");
	   Console.WriteLine($"{math.GetHomeworkList()}");
	   
	   // Create writing class.
	  WritingAssignment writingAssignment = new WritingAssignment("David Guttertrack","English 301","Technical Analysis"); 

	  // Print the summary of the class and the assignment.
	  Console.WriteLine(writingAssignment.GetSummary());
	  Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}
