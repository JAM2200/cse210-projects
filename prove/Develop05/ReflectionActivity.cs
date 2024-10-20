class ReflectionActivity : Activity
{
	// Set up a list of prompts and questions, the activity type, and the activity description.
	private List<string> _prompts = new List<string>();
	private List<string> _questions = new List<string>();
	private List<int> _randomQuestionIndexes = new List<int>();
	private string _description = "This activity will help you reflect on one experience you had.";
	private string _activityType = "reflecting";
		
	// Add prompts to the prompts list.
	private void PopulatePrompts()
	{
		_prompts.Add("Think of a time when you did something really difficult.");
		_prompts.Add("Think of a time when you did something really fun.");
		_prompts.Add("Think of a time when you were with your friends.");
		_prompts.Add("Think of a time when you were with your family.");
		_prompts.Add("Think of of your proudest accomplisment.");
		_prompts.Add("Think of of your favorite holiday experience.");
		_prompts.Add("Think of the most important person in your life.");
		_prompts.Add("Think of what accomplishments you have made in the last five years.");
		_prompts.Add("Think of one thing that you can change.");
	}

	// Add prompts to the prompt list. 
	private void PopulateQuestions()
	{
		_questions.Add("When was this experience?");	
		_questions.Add("How did it make you feel?");	
		_questions.Add("Why did you go thorugh this experience?");	
		_questions.Add("What did you learn from it?");	
		_questions.Add("Would you like to experience it again?");	
		_questions.Add("How did you feel when it ended?");	
	}
	
	// Return a random prompt from the list.
	private string GetRandomPrompt()
	{
		Random randomPromptIndex = new Random();
		return _prompts[randomPromptIndex.Next(0,_prompts.Count())];
	}

	// Return a random question from the list.
	private string GetRandomQuestion()
	{
		// Create a random object to and get a random index from 
		// the range of 0 to the number of questions.
		Random randomIndex = new Random();
		int index = randomIndex.Next(0,_questions.Count());

		// Save the index to a new variable to check to avoid repeat questions.
		// This is to excced core requirements.
		
		int newIndex = index;
		Console.WriteLine();

		// Check to if every question has been asked.  If so start over.
		if(_randomQuestionIndexes.Count() > _questions.Count())
		{
			_randomQuestionIndexes.Clear();
		}

		// Go through every question and check if it has been used. 
		for(int i = 0;i < _randomQuestionIndexes.Count();i++)
		{
			// Debug message.
			//Console.WriteLine($"i = {_randomQuestionIndexes[i]} newIndex = {newIndex}");
			// if the new question has been asked go to a different question.
			if(newIndex == _randomQuestionIndexes[i])
			{
				// Add one to the index for the random question.
				newIndex++;
				// If the new index is greater than last index of the list of questions, go to the first one.
				if(newIndex == _questions.Count())
				{
					newIndex = 0;
				}
			}

		}
		
		// Add the new index to the list of used indexes and return the random question.
		_randomQuestionIndexes.Add(newIndex);
		return _questions[newIndex];
	}
	
	
	// Set the parent activity description, and activity type, through the constructer. Also initialize the prompts and questoins lists. 
	public ReflectionActivity()
	{
		SetActivityDescription(_description);
		SetActivity(_activityType);
		PopulatePrompts();
		PopulateQuestions();
	}
	
	// Run the activity.
	public void Run()
	{
		// Call the parent activity.
		GetReady();
		bool done = false;
		// Get a random prompt and store it in a variable.
		string prompt = GetRandomPrompt();

		
		// Prompt the user and wait for them to press enter, then start the timer and clear the console.
		Console.WriteLine($"\n ---- {prompt} ----\nPress enter to continue...");
		Console.ReadLine();
		StartTimer();
		
		Console.Clear();

		// Continue until the timer ends.
		while(!done)
		{
			// Ask the user a question and give them ten
			// seconds to think about it.
			Console.Write($"\n> {GetRandomQuestion()} ");	
			SpinnerAnimation(10);
			done = EndTimer();
		}		
		
		// Write a new line and finish the activity.
		Console.WriteLine();
		FinishActivity();
	}

}
