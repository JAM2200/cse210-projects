using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

        string playAgain = "yes";
        while(playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            int numberOfGuesses = 0;
            string response;

            do
            {

                Console.Write("What is the magic number (enter q to quit or a number from 1 - 100)? ");
                response = Console.ReadLine();
                if(response == "q")
                {
                    continue;
                }
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

                numberOfGuesses++;
            }while(response != "q");

            Console.WriteLine($"You made {numberOfGuesses} guesses.\n");
            
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }

    }
}