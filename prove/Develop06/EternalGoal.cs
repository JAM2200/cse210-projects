class EternalGoal : Goal
{
	// Set up variable to store the bonus, the number of times the goal was completed,
	// and how many times the goals has to be complted before the user receives a one time bonus.

	private int _bonus = 100;
	private int _timesTillRandBonus = 0;
	private int _times = 0;

	// Set a constructor for convience.
	public EternalGoal(string goal, string description,int points) : base(goal, description,points)
	{
		// Set the type of goal as an eternal one.
		SetType("eternal");
		// Set up a time for the user to receive a one time bonus.
		Random randBonus = new Random();
		
		_timesTillRandBonus = randBonus.Next(5,10); 
	}

	// Create and empty constuctor for loading goals from a file.
	public EternalGoal()
	{
		// Set the type of goal as an eternal one.

		SetType("eternal");

		// Set up a time for the user to receive a one time bonus.

		Random randBonus = new Random();
		
		_timesTillRandBonus = randBonus.Next(5,10);
	}

	public override string GetDetailString()
    {
		// Return the details of the goal.
		string details = $" [ ] " + base.GetDetailString();
		return details;
    }

	// Set the number of times the goal has been completed.
	public void SetTimes(int times)
	{
		_times = times;
	}

	// Set the number of times the goals has to be completed to receive a one time bonus. 
	public void SetRandBonus(int randBonus)
	{
		_timesTillRandBonus = randBonus;
	}

	// Override the string the return by the base class. 
    public override string GetStringRepresentation()	
    {
		// basically the same as the base class but with chekclist specific details added.
		string details =  "Type: " + base.GetType() + " Goal: " + base.GetGoalName()+" Description: "+ base.GetDescription() + 
		" Completed: " + base.IsComplete() + " Points: " + base.GetPoints();
		return details + $" Times: {_times} RandomBonus: {_timesTillRandBonus}";
    }

	// Override the base class GetPoints method and return the base amount of points or with the added bonus. 
	// Bonus not part of the core requirements.
	public override int GetPoints()
	{
		_times++;

		int points = base.GetPoints();
		if(_times == _timesTillRandBonus)
		{
			points += _bonus;

			Console.WriteLine($"Congratulations on completig the goal {_times} times! You received a bonus of a {_bonus} points.");
		}

		return points;
	}

	// Set the goal status to incomplete because it is eternal.
    public override void CompleteGoal()
    {
		base.Unfinished(false);
    }
}
