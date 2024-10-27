using System.Runtime.InteropServices;

class SimpleGoal : Goal
{

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
		return base.IsComplete();
	}

    public override string GetDetailString()
    {
        return "Goal:" + GetGoal()+" Description: "+ GetDescription();
    }


}
