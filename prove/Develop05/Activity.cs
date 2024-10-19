class Activity
{
	private string _activityDescription = ""; 
	private string _activity = "";
	private DateTime _startTime; 
	private DateTime _endTime;
	private string _prompt = "How long, in seconds, would you like to run your activity? ";
	protected int _seconds;

	public Activity()
	{
	}

	Activity(string description, string activity)
	{
		_activityDescription = description;
		_activity = activity;
	}


	public string GetPrompt()
	{
		return _prompt;
	}

	public void SetActivity(string activity)
	{
		_activity = activity;
	}

	public string GetActivity()
	{
		return _activity;
	}
	
	public void SetActivityDescription(string activityDescription)
	{
		_activityDescription = activityDescription;
	}


	public void SetTimer()
	{
		
		_seconds = int.Parse(Console.ReadLine());
		
	}

	public void StartTimer()
	{
		_startTime = DateTime.Now;
		_endTime = _startTime.AddSeconds(_seconds);
	}

	public bool EndTimer()
	{
		DateTime currentTime = DateTime.Now;
		if(currentTime < _endTime)
		{
			return false;
		}else
		{
			return true;
		}
	}


	public void SpinnerAnimation(int duration)
	{
		for(int i = duration *2;i > 0;i--)
		{
				
			int animationCharacter = i % 4;
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
				default:
					break;
			}
			Thread.Sleep(500);		
		}
	}
	
	public void CountDownAnimation(int duration)
	{
		Console.Write(" ");
		for(int i = duration;i >= 0;i--)
		{
			Console.Write($"\b{i}");
			Thread.Sleep(1000);		
			
		}
		Console.Write($"\b\b");
	}

	private void DisplayActivityDescription()
	{
		Console.WriteLine($"\n{_activityDescription}\n");
		Console.Write(_prompt);
		SetTimer();
		Console.Write("Get Ready...|");
	}


	public void GetReady()
	{
		DisplayActivityDescription();
		SpinnerAnimation(4);
		Console.Clear();
	}

	public void FinishActivity()
	{
		Console.WriteLine($"Well done, you have completed {_seconds} seconds of the {_activity} activity.\n ");
		SpinnerAnimation(6);
		Console.Clear();
	}
	
		
}
