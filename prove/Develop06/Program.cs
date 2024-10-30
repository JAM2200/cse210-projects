using System;

class Program
{
    // Program to display all the option the user may make.
    static void DisplayMainMenu()
	{
		Console.WriteLine("1. Create New Goal");
		Console.WriteLine("2. List Goals");
		Console.WriteLine("3. Save Goals");
		Console.WriteLine("4. Load Goals");
		Console.WriteLine("5. Record Event");
		Console.WriteLine("6. Quit");
	}	
    static void Main(string[] args)
    {
        // Create a goal manager.
	    GoalManager GM = new GoalManager();

        // Create a variable to keep the program running until the user is done.
        bool done = false;

        while(!done)
        { 
            // Show the current score the user has.
            Console.WriteLine($"\nYou have earned {GM.GetPoints()} points!\n");
            
            // Display the options to the user.
            DisplayMainMenu();

            // Get the choice from the user.
            int choice = GM.GetUserChoice();

            // Manage the choice.
	        done = GM.ManageGoals(choice);


        }
    }
}
