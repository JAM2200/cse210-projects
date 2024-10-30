using System.Runtime.InteropServices;

class ChecklistGoal : Goal
{
	// Set up variable to store the number of times the goal was completed, how many time it needs to be complted
	// to recieve a bonus, and how much a bonus is.
	
	private int _timesCompleted = 0;
	private int _timesToComplete = 0;
	private int _bonus = 0;
	//Create a constructor to save set up the object.
	public ChecklistGoal(string goal, string description,int points) : base(goal, description,points)
	{	
		// Set the type of goal to a Checklist goal.
		SetType("checklist");
	}

	// Create an empty construcor for loading a goal from a file.
	public ChecklistGoal()
	{	
		// Set the type of goal to a Checklist goal.

		SetType("checklist");
	}

	// Set the number of times the goal was completed.  Used when loading from a file.
	public void SetCompletedTimes(int numberOfTimes)
	{
		_timesCompleted = numberOfTimes;
	}
	// Set the number of times the goals has to be completed to receive a bonus.
	public void SetTimes(int numberOfTimes)
	{
		_timesToComplete = numberOfTimes;
	}

	// Set how many points the bonus is worth.
	public void SetBonus(int bonus)	
	{
		_bonus = bonus;
	}


	// Override the GetstringRepresentation and checklist goals specific details.
    public override string GetStringRepresentation()
    {
		
        string details = base.GetStringRepresentation() + $" CompletedTimes: {_timesCompleted} NumberOfTimes: {_timesToComplete} Bonus: {_bonus}";
		return details;
    }

	// Override the GetDetailsString() method and add the number of times the goal has
	// been completed over the number of times to receive a bonus.
	
	public override string GetDetailString()
	{
		// If the goals is complete, put and x in the brackets.  Else leave it empty.
		if(IsComplete())
		{
			return " [X] " +base.GetDetailString() + $" {_timesCompleted}/{_timesToComplete}";
		}else
		{
			return " [ ] " +base.GetDetailString() + $" {_timesCompleted}/{_timesToComplete}";
		}
	}

	// Override the SetGoal Method() and add Checklist specific details.
    public override void SetGoal()
    {
        base.SetGoal();
		Console.Write($"How many times would you like to complete the goal? ");
		_timesToComplete = int.Parse(Console.ReadLine());
		Console.Write($"How many points would you like to receive for a bonus after doing it {_timesToComplete} times? ");
		_bonus = int.Parse(Console.ReadLine());
    }

	// Complete the goal.
    public override void CompleteGoal()
    {
		// If the goal is not finished, increment the number of times the goals was cpmpleted.
		if(!IsComplete())
		{
			_timesCompleted++;

			if(_timesCompleted == _timesToComplete)
			{
				base.CompleteGoal();
			}
		}
	}

	public override int GetPoints()
	{
		// Return the number of points base on whether the user should get a bonus or not. Or at all.
		if(!IsComplete())
		{
			if(_timesCompleted == _timesToComplete - 1)
			{
				return base.GetPoints() + _bonus;
			}
			return base.GetPoints();

		}

		return 0;

	}
}
