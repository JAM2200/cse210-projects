public class Goal
{
	private string _goal = "";
	private string _description = ""; 
	private int _points = 0;
	private bool _complete;
	private string _type = "";
	private string _detailString = ""; 

	public Goal(string goal,string description)
	{
		_goal = goal;
		_description = description;
	}

	public Goal()
	{
	}

	public string GetType()
	{
		return _type;
	}

	public void SetType(string type)
	{
		_type = type;
	}

	public void SetGoal(string goal)
	{
		_goal = goal;
	}

	public string GetGoal()
	{
		return _goal;
	}

	public void SetDescription(string description)
	{
		_description = description;
	}

	public string GetDescription()
	{
		return _description;
	}


	public void AddPoints(int pointsToAdd)
	{
		_points += pointsToAdd;
	}

	public virtual void RecordEvent()
	{
		Console.WriteLine($"1. I completed my {_goal} goal.");
		Console.WriteLine($"What did you do? ");
		int option = int.Parse(Console.ReadLine());

	}

	public virtual string GetStringRepresentation()
	{
		return "";
	}


	public virtual string GetDetailString()
	{
        	string details = "Type: " + GetType() + "\nGoal: " + GetGoal()+"\nDescription: "+ GetDescription() + "\nCompleted: " + IsComplete() + "\nPoint: " + GetPoints();
		return details; 
	}


	public int GetPoints()
	{
		return _points;
	}
	
	public virtual bool IsComplete()
	{
		return _complete;
	}

	public void CompleteGoal()
	{
		_complete = true;
	}

	public void AddDetail(string newDetail)
	{
		_detailString = _detailString + newDetail;
	}
}

