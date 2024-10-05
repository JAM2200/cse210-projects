using System;
// using System.Security.Cryptography.X509Certificates;

//
class Program
{   
    // Create a function to display what options the user may make. Including: making new entry, 
    // displaying previous entries loaded from a file and new entries not yet saved, loading a file that exists,
    // saving the new entries as well as the entries loaded from a file to  a new file or overwriting an existing one, 
    // and exiting the program. 

    static void DisplayMenu(){
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }

    // The program starts with main.    
    static void Main(string[] args)
    {
        // Create a variable to decide whether the program should continue.
        bool journaling = true;
        
        // Create and instance of the Journal class which is defined in ./Journal.cs
        Journal myJournal = new Journal();

        // Keep the program running until the user decides to stop editing journals.
        while (journaling){

            // Display the options and promptto the user, then store their choice as string.  
            DisplayMenu();
            Console.Write("What would you like to do? ");
            string storeChoice = Console.ReadLine();

            // Take the appropriate action based on the choice.
            switch(storeChoice){
                case "1":

                    // Make a new entry in a journal.
                    myJournal.MakeEntry();
                    break;
                case "2":

                    // Display all the new and loaded entries to the user.
                    myJournal.Display();
                    break;
                case "3":

                    // Load the journal with entries to the file.
                    myJournal.LoadJournal();
                    break;
                case "4":

                    // Save the new and loaded entries to a file with the filename as ".txt" file.
                    myJournal.SaveEntries();
                    break;
                case "5":

                    // Exit the program.
                    Console.WriteLine("Exiting the program...");
                    // Set journaling to false so that the while loop stops.
                    journaling = false;
                    break;
                default:
                    break;                    
            }
        }
        
    }
}
