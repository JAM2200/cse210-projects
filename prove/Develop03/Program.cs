using System;

class Program
{
	static void PresentMenu()
	{
		Console.WriteLine("1. Memorize");
		Console.WriteLine("2. Enter New Scripture");
		Console.WriteLine("3. Quit");
		Console.Write("Enter an option: ");
	}

    static void Main(string[] args)
    {
	PresentMenu();	
	string choice = Console.ReadLine();

	string scriptures = @"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
	Reference reference = new Reference("Proverbs",3,5,6);	
	Scripture scripture = new Scripture(scriptures,reference);
	scripture.Memorize();
	    
    }
}
