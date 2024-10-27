class ChecklistGoal : Goal
{
	public ChecklistGoal(string goal, string description) : base(goal, description)
	{	
		SetType("checklist");
	}
}
