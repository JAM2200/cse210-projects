using System.Runtime.InteropServices;

class SimpleGoal : Goal
{

	public SimpleGoal()
	{
	}	

	public SimpleGoal(string goal, string description) : base(goal,description)
	{
		SetType("simple");
	}

	public override void RecordEvent()
	{
		base.RecordEvent();
	}

	public override bool IsComplete()
	{
		AddPoints(500);
		return base.IsComplete();
	}

    public override string GetDetailString()
    {
	string details = base.GetDetailString();
	return details;
    }


}
