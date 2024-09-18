using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for his or her grade percentage and store the answer.
        Console.Write("What is your grade (enter as %)? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;
        
        // Check which letter grade his or her percentage corresponds to, and store that in a varible.
        if(gradePercentage >= 90)
        {
            letterGrade = "A";
        }else if(gradePercentage >= 80)
        {
            letterGrade = "B";
        }else if(gradePercentage >= 70)
        {
            letterGrade = "C";

        }else if(gradePercentage >= 60)
        {
            letterGrade = "D";
        }else if(gradePercentage < 60)
        {
            letterGrade = "F";
        }else{
            letterGrade = " ";
        }

        // Print out the user's letter grade.
        Console.WriteLine($"Your grade is: {letterGrade}");

        // If the user got a grade greater than 70 inform the user that he or she passed the class.
        if(gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better Luck next time.");
        }
    }
}