using System;
using System.Text.Json.Serialization;

class Program
{
        static void PresentMenu()
        {
                Console.WriteLine("1. Memorize");
                Console.WriteLine("2. Create New Scripture");
                Console.WriteLine("3. Quit");
                Console.Write("Enter an option: ");
        }

        // Reference reference;


    static void Main(string[] args)
    {
                FileHandler file = new FileHandler();
                bool memorizing = true;

                while(memorizing)
                {
                        PresentMenu();

                        string choice = Console.ReadLine();


                        switch(choice)
                        {
                                case "1":
                                        file.ListVerses();
                                        // scripture.Memorize();
                                        break;
                                case "2":
                                        Console.Write("Enter a file name: ");
                                        string fileName = Console.ReadLine();
                                        NewVerse verse = new NewVerse();

                                        verse.CreateVerse();

                                        file.SaveFile(fileName,verse.GetVerseContents(),verse.GetReference());
                                        break;
                                case "3":
                                        memorizing = false;
                                        break;
                                default:
                                        break;
                        }
                }

        // string scriptures = @"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        // Scripture scripture = new Scripture(scriptures,reference);
            
    }
}
