using System;

class Program
{
    //Function to display welcome message.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    } 

    // Prompt the user for his or her user name and return it. 
    static string PromptUserName()
    {
        Console.Write("Enter your user name: ");
        return Console.ReadLine();
    }

    // Prompt the user for his or her user number and return it. 
    static int PromptUserNumber()
    {
        Console.Write("Enter your user number: ");
        return int.Parse(Console.ReadLine());
    } 

    // Take the number given and return the square of it.
    static int SquareNumber(int numberToSquare)
    {
        return numberToSquare * numberToSquare;
    }

    // Display a string and a number to the console.
    static void DisplayResult(string userName, int number){
        Console.WriteLine($"{userName}, the square of your number is: {number}");
    }

    static void Main(string[] args)
    {
        // Get the user's user name, and number, then display the name and the number squared to the console. 
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
}