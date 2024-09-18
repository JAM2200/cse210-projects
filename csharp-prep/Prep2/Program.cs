using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (enter as %)? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;

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

        Console.WriteLine($"Your grade is: {letterGrade}");

        if(gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better Luck next time.");
        }
    }
}