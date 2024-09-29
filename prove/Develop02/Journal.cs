using System.Threading.Tasks.Dataflow;

public class Journal{

    // Create a list of prompts to be randomly chosen by the computer when the user make a new entry.
    List<string> _prompts = new List<string>(new string[]{"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // New prompts added by me.
        "What was on my mind the most today?",
        "What am I going to do tomorrow?",
        "How did I accomplish my goals today?",
        "Where did I go today?"
    });
    


    // Create a variable to store new and old entries in a list.  It is property because it will be used in multiple functions.
    public List<string> _newEntries = new List<string>();

    // Create a variable to store a prompt.
    public string _newEntryPrompt = "";

    // Generate a random prompt from the list of _prompts to have the user respond to. Then store it in _newEntryPrompt.
    private void PickRandomPrompt(){
        Random randomPrompt = new Random();
        
        _newEntryPrompt = _prompts[randomPrompt.Next() % (_prompts.Count - 1)];
    }

    // This function creates a new entry for the journal.
    public void MakeEntry(){
        
        // Generate a prompt and display it.
        PickRandomPrompt();
        Console.Write($"{_newEntryPrompt}\n> ");

        // Get the current date and store it in a varible for future use.
        DateTime date = DateTime.Now;

        // Get the response from the user and create a new entrye with the current date, random prompt, and the user's response.
        string entry = Console.ReadLine();
        _newEntries.Add($"Date: {date.ToShortDateString()} - Prompt: {_newEntryPrompt}\n{entry}");
        // _newEntries.Add($"{entry}");
    }

    // Show all entries to the user.  It inlcludes new entries and entries loaded from a file. 
    public void Display(){
        foreach(string entry in _newEntries){
            Console.WriteLine($"{entry}");
            Console.WriteLine();
        }
    }
 
    // Save the Journal to a new or already existing file.
    public void SaveEntries()
    {
        // Prompt the user for a new or existing file name.  May contain ".txt", if not it will be appended at the end.

        Console.Write("Enter a file name: ");
        string fileName = Console.ReadLine();

        // Create an instance of the FileHandler class so that the journal can be saved.
        FileHandler newJournal = new FileHandler();

        // Save the entries to the journal.
        newJournal.SaveFile(fileName, _newEntries);
    }

    public void LoadJournal()
    {
        // Create an instance of the FileHandler class so that a journal can be loaded.
        FileHandler file = new FileHandler();

        file.ListJournals();

        // Prompt the user for a new or existing file name.  May contain ".txt", if not it will be appended at the end.
        Console.Write("Enter the name of the journal: ");
        string fileName = Console.ReadLine();

        

        // Load a file and add the save entries to the _newEntries variable.
        file.LoadFile(fileName, _newEntries);

    }

    
    
}

