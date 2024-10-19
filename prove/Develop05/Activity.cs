class Activity
{
	/* Set up variables for the type of activity, a description of the activity, how long the acitivity is going to take in seconds,
	 * the time the activity starts, the time when the activity ends, and a prompt for the user to enter the length of the activity.
	 */
	private string _activityDescription = ""; 
	private string _activity = "";
	private DateTime _startTime = DateTime.Now; 
	private DateTime _endTime = DateTime.Now;
	private string _prompt = "How long, in seconds, would you like to run your activity? ";
	protected int _seconds;
	private bool isRunning = false;

	// Empty Constructor just in case.
	public Activity()
	{
	}

	// A constructor to set up the type of activity and its description.
	Activity(string description, string activity)
	{
		_activityDescription = description;
		_activity = activity;
		_endTime = _startTime.AddSeconds(3600);
	}


	//  Get the prompt for the number of seconds.
	public string GetPrompt()
	{
		return _prompt;
	}


	// Set the type of activity.  Such as "breathing," "listing," and "reflecting."
	public void SetActivity(string activity)
	{
		_activity = activity;
	}

	// Return the type of activity.  Such as "breathing," "listing," and "reflecting."
	public string GetActivity()
	{
		return _activity;
	}
	
	// Set the activity description.  Used in the child activity classes.
	public void SetActivityDescription(string activityDescription)
	{
		_activityDescription = activityDescription;
	}

	// Set how long the activity is going to take in seconds through user input.
	private void SetTimer()
	{
		_seconds = int.Parse(Console.ReadLine());
	}

	// Start the timer.
	public void StartTimer()
	{
		// Let the program know that the timer is running.
		isRunning = true;
		// Get the current time and store it.
		_startTime = DateTime.Now;
		// Set the end time to the start time plus the number of seconds entered by the user.
		_endTime = _startTime.AddSeconds(_seconds);
	}

	// Check to see if the current time is less than the end time.
	public bool EndTimer()
	{
		// Get the current time to compare against.
		DateTime currentTime = DateTime.Now;
		if(currentTime < _endTime)
		{
			// If the current time is less than the end time, the activity is not over yet.
			return false;
		}else
		{
			// Else the activity is over.
			isRunning = false;
			return true;
		}
	}

	// Create a spinner animation.
	public void SpinnerAnimation(int duration)
	{
		// go through the animation twice as many times as the duration.
		for(int i = duration *8;i > 0;i--)
		{
				
			// Calculate which character should be displayed by taking the modulus of i.  There are four charactors "|," "/," "-," and "\."
			// When it is 0 or 4, display "|," when it is 3 or 7, display "/," when it is 6 or 2, display "-," when it is 5 or 1, display "\." 
			int animationCharacter = i % 8;
			switch(animationCharacter)
			{
				case 0:
					Console.Write("\b|");
					break;
				case 1:
					Console.Write("\b\\");
					break;
				case 2:
					Console.Write("\b-");
					break;
				case 3:
					Console.Write("\b/");
					break;
				case 4:
					Console.Write("\b|");
					break;
				case 5:
					Console.Write("\b\\");
					break;
				case 6:
					Console.Write("\b-");
					break;
				case 7:
					Console.Write("\b/");
					break;
				default:
					break;
			}
			// Since there are eight steps to the animation, make each part display for an eighth of a second.
			Thread.Sleep(125);		

			// Check to see if the program should end. Used for the spinner in the reflecting activity.
			if(isRunning && EndTimer())
			{
				break;
			}

		}
	}
	
	// Diplay a countdown for a number of seconds passed in as an argument.
	public void CountDownAnimation(int duration)
	{
		// Write a space so that it can be erased instead of something else.
		Console.Write(" ");
		for(int i = duration;i >= 0;i--)
		{
			// Erase the last character and display the second.
			Console.Write($"\b{i}");
			// If the last second is up, break out of the loop so that another second is not accidently added.
			if(i == 0)
			{
				break;
			}
			// Wait a second.
			Thread.Sleep(1000);		
			// Check to see if the timer is ended, otherwise the counter will add time to the activity.
			if((EndTimer() && isRunning) )
			{
				Console.Write($"\b0");
				break;
			}
			
		}
	}

	// Display the instructions. And set the timer.
	private void DisplayActivityDescription()
	{
		Console.WriteLine($"\n{_activityDescription}\n");
		Console.Write(_prompt);
		SetTimer();
		Console.Clear();
		Console.Write("Get Ready...|");
	}


	// Display the instrctions, print out the spinner animation and write a new line.
	public void GetReady()
	{
		
		DisplayActivityDescription();
		SpinnerAnimation(4);
		Console.WriteLine();
	}
	
	// After the activiity is finished, give a complement and print out a spinner animation for them to read.
	// Let them see how long they did the activity for.
	// Clear the console to back to the menu.
	public void FinishActivity()
	{
		isRunning = false;
		Console.WriteLine("Well Done!!!\n");
		SpinnerAnimation(4);
		Console.WriteLine($"\n\nYou have completed {_seconds} seconds of the {_activity} activity.\n ");
		SpinnerAnimation(4);
		Console.Clear();
	}
	
		
}
