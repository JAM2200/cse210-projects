class BreathingActivity : Activity
{
		
	// Set up the variables for which way to breath, how long to breath in or out, store the type of activity, and the activity description.
	private string _breathIn = "Breath in...";
	private string _breathOut = "Breath out...";
	private bool _out = false;
	private int _promptTimer = 0;
	private int _breathInTimer = 4000;
	private int _breathOutTimer = 6000;
	private string _activity= "breathing";
	private string _prompt = "This activity will help you relax by walking you through the steps of breathing in and out slowly.  Clear your mind and focus on your breathing.";

	// Set the parent activity description, and activity type, through the description. 
	public BreathingActivity()
	{
		SetActivityDescription(_prompt);
		SetActivity(_activity);
	}

	// Return an instruction to breath in or out.
	public string GetActionPrompt()
	{
		if(_out)
		{
			_out = false;
			_promptTimer = _breathInTimer;
			return _breathOut;
		}else
		{
			_out = true;
			_promptTimer = _breathOutTimer;
			return _breathIn;
		}
	}

	// Run the program in a loop.
	public void Run()
	{
		// Call the parent get ready and start timer functions.
		GetReady();
		StartTimer();
		// create a variable to check whether the activity is done or not.
		bool done = false;
		while(!done)
		{
			// Check to see if the timer is up.
			if(!EndTimer())
			{

				// If not, display the next instruction and count down.
				Console.Write($"\n{GetActionPrompt()}");
				CountDownAnimation(_promptTimer / 1000);
				// Write a new line.
				Console.WriteLine();
			}else
			{
				// Else end the activity.
				done = true;
			}
		}
		
		// Call the parent finish activity.
		FinishActivity();

	}
}

