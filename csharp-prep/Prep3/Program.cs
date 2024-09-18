using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Create game loop for the user to play as many rounds as he or she wants.
        string playAgain = "yes";
        while(playAgain == "yes")
        {

            // Generate a random number for the user to guess.
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            // Create varibles to store the user's guess and how many guesses are made.
            int numberOfGuesses = 0;
            string response;


            // Create a loop to let the user keep guessing the random number until it is guessed.
            do
            {

                // Prompt to guess the random number and store it in a varible.        
                Console.Write("What is the magic number (enter q to quit or a number from 1 - 100)? ");
                response = Console.ReadLine();

                // If the user entered q, skip the rest of the loop.
                if(response == "q")
                {
                    continue;
                }

                // Check to see if the user guessed correctly and display the appropriate response.
                int guess = int.Parse(response);
                if(guess == magicNumber)
                {
                    Console.WriteLine("You guessed the magic number.");
                    response = "q";
                }else if(guess < magicNumber)
                {
                    Console.WriteLine("Guess a higher number.");
                }else if(guess > magicNumber)
                {
                    Console.WriteLine("Guess a lower number.");
                }

                // Increment the number of guesses made by the user.
                numberOfGuesses++;
            }while(response != "q");

            // Display the number of guesses made and ask the user if he or she wants to play again.
            Console.WriteLine($"You made {numberOfGuesses} guesses.\n");
            
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

    }
}