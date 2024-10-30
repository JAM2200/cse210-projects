using System.Dynamic;

public class Goal
{
	// Set up variables to store the goal name, its description, the points it is worth when it is completed, the type of
	// the goal and whethet is is completed.
	private string _goal = "";
	private string _description = ""; 
	private int _points = 0;
	private bool _complete;
	private string _type = "";

	// Create a constructor to initialize valuse.  Is not used in this program.
	public Goal(string goal,string description,int points)
	{
		_goal = goal;
		_description = description;
		_points = points;
	}

	// Empty constructor for loading goals from a file.
	public Goal()
	{
	}

	// Return the type of the goal.
	public string GetType()
	{
		return _type;
	}

	// Set the type of the goal as simple, eternal, or a checklist goal.
	public void SetType(string type)
	{
		_type = type;
	}

	// Set the name of the goal.
	public void SetGoalName(string goal)
	{
		_goal = goal;
	}

	// Return the name of the goal.
	public string GetGoalName()
	{
		return _goal;
	}

	// Set the goals a completed or not completed.
	public void Unfinished(bool complete)
	{
		_complete = complete;
	}

	//  Set the goal descriptoin.
	public void SetDescription(string description)
	{
		_description = description;
	}

	// Return the deescription.
	public string GetDescription()
	{
		return _description;
	}


	// Set the number of points it is worth when it is completed.
	public void SetPoints(int pointsToAdd)
	{
		_points = pointsToAdd;
	}

	// Return the details of the string in a "value: key," format.
	public virtual string GetStringRepresentation()
	{
		string details =  "Type: " + 	GetType() + " Goal: " + GetGoalName()+" Description: "+ GetDescription() + 
		" Completed: " + IsComplete() + " Points: " + GetPoints();
		return details; 
	}

	// Return the name and the description of the goal.

	public virtual string GetDetailString()
	{

		return $"{GetGoalName()} ({GetDescription()})";
	}


	// Return the number of points.  This method is morphed in child classes, hence the virtual keyword.
	public virtual int GetPoints()
	{
		return _points;
	}
	
	// Return whether the goal is complete or not.
	public virtual bool IsComplete()
	{
		return _complete;
	}

	// Mark the goals as complete.
	public virtual void CompleteGoal()
	{
		_complete = true;
	}

	// Get the user to enter infomation about the goal.  It is also modified in the child classes.
	public virtual void SetGoal()
	{
		// Get the goal name.
		Console.Write("Enter a name: ");
		_goal = Console.ReadLine();
		// Get the description of the goal.
		Console.Write("Enter a description: ");
		// Get how many points the goal is worth when it is completed.
		_description = Console.ReadLine();
		Console.Write("Enter how many points the goals is worth when it is completed: ");
		_points =  int.Parse(Console.ReadLine());
	}
}

