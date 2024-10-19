class BreathingActivity : Activity
{
		
	private string _breathIn = "Breath in...";
	private string _breathOut = "Breath out...";
	private bool _out = false;
	private int _promptTimer = 0;
	private int _breathInTimer = 4000;
	private int _breathOutTimer = 6000;
	private string _activity= "breathing";
	private string _prompt = "This activity will help you relax by walking you through the steps of breathing in and out slowly.  Clear your mind and focus on your breathing.";

	public BreathingActivity()
	{
		SetActivityDescription(_prompt);
		SetActivity(_activity);
	}

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

	public void Run()
	{
		GetReady();
		StartTimer();
		bool done = false;
		while(!done)
		{
			if(!EndTimer())
			{

				Console.Write($"\n{GetActionPrompt()}");
				CountDownAnimation(_promptTimer / 1000);
				Console.WriteLine();
			}else
			{
				done = true;
			}
		}
		
		FinishActivity();

	}
}

