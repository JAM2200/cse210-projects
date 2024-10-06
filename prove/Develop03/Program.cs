using System;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Transactions;


// This program lets the usere memorize a scripture of their choice.  They can enter the scripture and the program will save it to a file so 
// that the users does not have to enter it every time they want to work on memorizing.  They can enter multiple scriptures and 
// choose which one to work on.
// While the user is memorizing, they can hit enter and two of the words will disappear from the screen.
// They can keep doing that untill the entire scripture is hidden at which point they are presented with the same options
// they had when the program was started.
// The program keeps going until the users quits.

// The menu and saving the verse were to go beyond the core requirments.
class Program
{

		// Present a list of opthions the user can take.
        static void PresentMenu()
        {
                Console.WriteLine("1. Memorize");
                Console.WriteLine("2. Create New Scripture");
                Console.WriteLine("3. Quit");
                Console.Write("Enter an option: ");
        }


	// Main function, program starts here.
    static void Main(string[] args)
    {
				// Create a variable to handle new and existing file.
                FileHandler file = new FileHandler();

				string defaultVerse = @"Trust in the Lord with all thine heart; and lean not unto thine own understanding.
6 In all thy ways acknowledge him, and he shall direct thy paths.";
				Reference proverbsRef = new Reference("Proverbs",3,5,6);
				Scripture proverbs = new Scripture(defaultVerse, proverbsRef);

				// create a variable to marke whether the program should end.

                bool memorizing = true;
				

				// Keep letting the user choose what to do until their finished.
                while(memorizing)
                {
						// Present the menu.
					PresentMenu();
				

					// Get a choice from the user.
					string choice = Console.ReadLine();

					// Decide what to do depending on the choice.
					switch(choice)
					{
							
						case "1":
								// Display the verses the user has entered and let them choose which one to memorize.

								// Check if there are any scitptures that can be memorized and list them.								
								bool canMemorize = file.ListVerses();
								Console.WriteLine("Default");

								// Make sure there are verse that can be accesed by the program.
								if(canMemorize)
								{
									// Prompt the user for a scripture to memorize.
									Console.Write("\nEnter the fileName(with or without the \".txt\") or default to practice the default verse: ");	
									string fileName = Console.ReadLine();
									
										// Create the variables to store a scripture, and create a scripture reference and scripture.
										List<string> referenceParts = new List<string>();
										file.LoadFile(fileName, referenceParts);

										// If the list is empty that means the file does not exist.
										if(referenceParts.Count != 0)
										{
											Reference scriptureReference = new Reference(referenceParts[0],int.Parse(referenceParts[1]),int.Parse(referenceParts[2]),int.Parse(referenceParts[3]));

											Scripture scripture = new Scripture(referenceParts[4],scriptureReference);
										
											// Memorize the scripture.
											scripture.Memorize();
										}

										// Memorize the scripture stored in the file.
										if(fileName.ToLower() == "default")
										{
											proverbs.Memorize();
										}

										
								}else
								{
									// If there aren't any scriptures entered by the user. Memorize the scripture stored in the program.
						            proverbs.Memorize();

								}
								break;
						case "2":
								// Create a verse and store it in a file.

								// Have the user enter the name of the file to save.
								Console.Write("Enter a file name: ");
								string loadFileName = Console.ReadLine();
								// Create a new verse. Get the book, chapter, verse, endverse and verse.
								NewVerse verse = new NewVerse();
								verse.CreateVerse();
								
								// Save the verse to a file.
								file.SaveFile(loadFileName,verse.GetVerseContents(),verse.GetReference());
								break;
						case "3":

								// Quit the program.
								memorizing = false;
								break;
						default:
							// In case one of the options is not entered.
							break;
					}
                }


            
    }
}
