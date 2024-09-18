using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for his or her first and last names, and store them in varibles.
        string firstName, lastName;
        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();


        // Print out the name in a James Bond fashion. 
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}