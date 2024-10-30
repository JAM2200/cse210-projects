using System;

class GoalManager
{
	// Set up variables for a list of goal, the goal type, and number of points the user has.
	private List<Goal> _goals = new List<Goal>();
	private string _goalType = "";
	private int _points = 0; 

	// Add points for the user.
	public void AddPoints(Goal goal)
	{
		// If a goal is not complete add points for it.
		if(!goal.IsComplete())
		{
			// Get the points for the goal.
			int pointsToAdd = goal.GetPoints();
			// Inform the user  of how many points they have.
			Console.WriteLine($"You have earned an additional {pointsToAdd} points!");
			// Set the goal as complete.
			goal.CompleteGoal();
			// Add the points to the _points variable.
			_points += pointsToAdd;
		}else
		{
			// If the goas is complete and cannot be worked on, let the user that that is the case.
			Console.WriteLine($"Sorry, the goal \"{goal.GetGoalName()},\" has been completed already.");
		}
	}

	// Get points the user has.
	public int GetPoints()
	{
		return _points;
	}

	// Display the types of goals the user can create.
	private void DisplayGoalMenu()
	{
		Console.WriteLine($"1. Simple Goal");
		Console.WriteLine($"2. Checklist goal");
		Console.WriteLine($"3. Eternal Goal");
	}

	// Mange the goals through the choice the user makes.
	public bool ManageGoals(int choice)
	{
		// Set a variable to let the program know if the use exited the program.
		bool done = false;

			// Take the appropriate action given the choice. 
			switch(choice)
			{
				// Create a new goal.
				case 1:
					// Display the types of goals to the user.
					DisplayGoalMenu();
					int goalChoice = GetUserChoice();
					// Set the goal type.
					SetGoalType(goalChoice);
					// Create a new goal.
					CreateNewGoal();
					break;
					
					// Show the goals the user has created of loaded from a file. 
				case 2:
					ShowGoals() ;
					break;

				case 3:
					
					// Save the current goals to a file.
					SaveGoals();
					break;
				case 4:
					// Load goals from a file.
					LoadGoals(-1);
					break;
				case 5:
					// Let the user update the status of a goal.
					RecordEvent();
					break;
				case 6:
					// End the program.
					done = true;
					break;
				default:
					break;
			}
			// Return whether the user is done or not. 
			return done;
	}


	// Print a prompt to the use, and get a choice as an integer from the user.
	public int GetUserChoice()
	{
		Console.Write("Enter and option: "); 
		return int.Parse(Console.ReadLine());
	}

	
	// Set the type of goal.
	private void SetGoalType(int type)
	{
		// set the goal type according to the number passed in.
		// 1 means the new goals is a simple goal. 2 means it is a checklist goal, and 3 means it is an eternal goal.
		switch(type)
		{
			case 1:
				_goalType = "simple";
				break;
			case 2: 
				_goalType = "checklist";
				break;
			case 3:
				_goalType = "eternal";
				break;
			default:
				break;
		}
	}

	// Let the user mark a goal as completed.
	private void RecordEvent()
	{
		// Display the goals loaded in the program.
		int index = 1;
		foreach(Goal goal in _goals)
		{
			Console.WriteLine($"{index}. {goal.GetGoalName()}");
			index++;
		}

		// Have the user pick one to mark complete.
		Console.Write("What goal did you Accomplish? ");
		int choice = GetUserChoice();
		
		// Make sure the user entered a valid number.
		if( choice <= _goals.Count() && choice >= 0)
		{
			// Add points for completing a goal.
			AddPoints(_goals[choice - 1]);
		}else
		{
			// Let the user know that their input was invalid.
			Console.WriteLine($"Try again, {choice} is not a valid option.");
		}
	}

	// Create a new goal and store it in a list.
	private void CreateNewGoal()
	{
		// Create the correct type of goal.
		switch(_goalType.ToLower())
		{
			// Create a simple goal and add it to the list.
			case "simple":
				SimpleGoal newSimpleGoal = new SimpleGoal();
				newSimpleGoal.SetGoal();
				_goals.Add(newSimpleGoal);
				break;

			// Create a eternal goal and add it to the list.
			case "eternal":
				EternalGoal newEternalGoal = new EternalGoal();
				newEternalGoal.SetGoal();
				_goals.Add(newEternalGoal);
				break;
				
			// Create a checklist goal and add it to the list.
			case "checklist":
				ChecklistGoal newChecklistGoal = new ChecklistGoal();
				newChecklistGoal.SetGoal();
				_goals.Add(newChecklistGoal);
				break;
			default:
				break;
		}
		
	}

	// Show the goals to the user.
	public void ShowGoals()
	{
		// Make sure there is at least one goal.
		if(_goals.Count() > 0)
		{
			// If there is iterate through the list in the format of: "number. goal namd (goal description)." 
			int index = 1;
			foreach(Goal goal in _goals)
			{
				Console.WriteLine($"\n{index}. {goal.GetDetailString()}\n");
				index++;
			}
		}else
		{
			// If there are not any goals in the list let the user know.
			Console.WriteLine("\nNo goals loaded or created yet.\n");
		}
	}


	// Load goals from a file and add them to the list.
	private void LoadGoals(int fileNumber)
	{
		// Create file handler object o interact with the file.
		FileHandler file = new FileHandler();

		// Show the file that contain goals saved by the user.
		file.ShowGoalFiles();

		// Have the user choose one.
		Console.Write("Enter the name of the file to load: ");
		string fileName = Console.ReadLine();

		// Load the file and add the total points already earned to the _points variable.
		_points += file.LoadFile(fileName,_goals);
	}

	// Save the current goals in the list in a file.
	private void SaveGoals()
	{
		// Create a string containg all the information in a line.  Save the number of points the user has earned from these goals.
		string goalList = $"Points: {_points}";
		foreach(Goal goal in _goals)
		{
			goalList = goalList + "\n" + goal.GetStringRepresentation();
		}

		// Have the user enter a filename to save the goals in.
		Console.Write($"Enter a filename to save the goals: ");
		string fileName = Console.ReadLine();
		FileHandler newFile = new FileHandler();
		
		// Save the file.
		newFile.SaveFile(fileName,goalList);
	}


}


