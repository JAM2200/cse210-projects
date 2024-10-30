using System.Runtime.InteropServices;

class SimpleGoal : Goal
{

	// Empty Constructor to set the type of the variable. 
	public SimpleGoal()
	{
		SetType("simple");
	}	

	// Create a constructor to set up the object.
	public SimpleGoal(string goal, string description, int points) : base(goal,description,points)
	{
		SetType("simple");
	}

	// Overrid the GetDetailString method and change it up a bit.
    public override string GetDetailString()
    {
		// Create a varible to show whether the goal is complete
		// X if it is and a space if it is not.
		string checkX = " ";
		if(IsComplete())
		{
			checkX = "X";
		}

		// Place the string first and add the base method after.
		string details = $"[{checkX}] " + base.GetDetailString();

		// Return the new string for later use.
		return details;
    }


}
