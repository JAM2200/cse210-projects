using System;

class GoalManager
{
	private List<Goal> _goals = new List<Goal>();
	private string _goalType = ""; 

	public void DisplayMainMenu()
	{
		Console.WriteLine("1. Simple Goals");
		Console.WriteLine("2. Eternal Goals");
		Console.WriteLine("3. Checklist Goals");
		Console.WriteLine("4. Exit");
	}						

	private void DisplayGoalMenu()
	{
		Console.WriteLine($"1. Update Current {_goalType} Goal");
		Console.WriteLine($"2. Show Current {_goalType} Goals");
		Console.WriteLine($"3. Create New {_goalType} Goal");
		Console.WriteLine($"4. Back to Main Menu");
	}

	public int GetUserChoice()
	{
		Console.Write("Enter and option: "); 
		return int.Parse(Console.ReadLine());
	}

	public void ManageGoals()
	{

		bool done = false;
		while(!done)
		{
			DisplayMainMenu();
			int choice = GetUserChoice();
			switch(choice)
			{
				case 1:
					_goalType = "simple";
					
					break;
				case 2:
					_goalType = "eternal";
					break;

				case 3:
					_goalType = "checklist";
					break;
				case 4:
					done = true;
					Console.Clear();
					break;

				default:
					break;
			}
			if(choice < 4)
			{
				HandleGoalMenuChoice();
			}
			
			Console.Clear();
			
		}
	}


	public void HandleGoalMenuChoice()
	{
		Console.Clear();


		bool done = false;
		while(!done)
		{
			DisplayGoalMenu();
			int choice = GetUserChoice();
			switch(choice)
			{
				case 1:
					Console.Clear();

					break;
				case 2:
					Console.Clear();
					ShowGoals();
					break;
				case 3:
					Console.Clear();
					CreateNewGoal();
					break;
				case 4:
					done = true;
					break;
				default:
					break;
			}
		}
	}
	
	private void CreateNewGoal()
	{
		Console.Write("Enter a name: ");
		string goalName = Console.ReadLine();
		Console.Write("Enter a description: ");
		string description = Console.ReadLine();

		switch(_goalType.ToLower())
		{
			case "simple":
				SimpleGoal newSimpleGoal = new SimpleGoal(goalName, description);
				_goals.Add(newSimpleGoal);
				break;
			case "eternal":
				EternalGoal newEternalGoal = new EternalGoal(goalName, description);
				_goals.Add(newEternalGoal);
				break;
			case "checklist":
				ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, description);
				_goals.Add(newChecklistGoal);
				break;
			default:
				break;
		}
		
		SaveGoal(goalName,_goals[_goals.Count() - 1].GetDetailString());
		
	}

	public void ShowGoals()
	{
		foreach(Goal goal in _goals)
		{
			Console.WriteLine(goal.GetType());

			if(goal.GetType().ToLower() == _goalType)
			{
				Console.WriteLine(goal.GetDetailString());
			}
		}

		FileHandler goalFiles = new FileHandler(_goalType);
		
		goalFiles.ShowGoals();
	}

	private void UpdateStatus()
	{
		
		switch(_goalType.ToLower())
		{
			case "simple":
				SimpleGoal newSimpleGoal = new SimpleGoal(goalName, description);
				_goals.Add(newSimpleGoal);
				break;
			case "eternal":
				EternalGoal newEternalGoal = new EternalGoal(goalName, description);
				_goals.Add(newEternalGoal);
				break;
			case "checklist":
				ChecklistGoal newChecklistGoal = new ChecklistGoal(goalName, description);
				_goals.Add(newChecklistGoal);
				break;
			default:
				break;
		}
	}

	private void LoadGoals()
	{

	}

	private void SaveGoal(string fileName,string goalDetails)
	{
		FileHandler newFile = new FileHandler(_goalType);

		newFile.SaveFile(fileName,goalDetails);
	}


}


