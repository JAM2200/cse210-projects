class ListingActivity : Activity
{
	// New comment
	
	/*
	 * Declare an initialize variables for a list of prompts, responses, activitgy descriptoins, and the type.
	 */ 
	private List<string> _prompts = new List<string>(new string[]{
			"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    });

	private List<string> _responses = new List<string>();
	private string _description = "In this activity you will list actions you did to work on something.";
	private string _activityType = "listing";

	
	// Set the parent activity description, and activity type, through the constructor. 
	public ListingActivity()
	{
		SetActivityDescription(_description);
		SetActivity(_activityType);
	}
	
	// Randomly select a prompt from the list of prompts.
	public string  GetRandomPrompt()
	{
		// Create a random object.
		Random randomNumber = new Random();
		// Get the next random number from a range of 0 - the number of prompts
		// and use that as an index.
		int randomIndex = randomNumber.Next(0,_prompts.Count());
		return _prompts[randomIndex];
	}
		

	// Run the Program
	public void Run()
	{
		// Call the parent get ready function.
		GetReady();
		// Generate a prompt.
		string prompt = GetRandomPrompt();
	
		// Give an instruction to the user so they know what to do.
		Console.WriteLine($"List as many responses to the following prompt: \n---- {prompt} ----");
		// Let the user know how many seconds they have before they begin.
		// Give them five seconds to think about what to write.
		Console.Write("You may begin in: ");
		CountDownAnimation(5);
		Console.WriteLine();
		// Start the timer and let the user respond to the prompt.
		StartTimer();
		while(!EndTimer())
		{
			// Prompt the user and store the response in a list.
			Console.Write("> ");
			_responses.Add(Console.ReadLine());
		}
			
		// Let the user know how many things they typed in and finish the activity.
		Console.WriteLine($"You typed in {_responses.Count()} things.");			
		FinishActivity();
	}

}

