using System;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    } 

    static string PromptUserName()
    {
        Console.Write("Enter your user name: ");
        return Console.ReadLine();
    }
     
    static int PromptUserNumber()
    {
        Console.Write("Enter your user number: ");
        return int.Parse(Console.ReadLine());
    } 


    static int SquareNumber(int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }

    static void DisplayResult(string userName, int number){
        Console.WriteLine($"{userName}, the square of your number is: {number}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
}