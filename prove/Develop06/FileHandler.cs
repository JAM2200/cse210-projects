using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
public class FileHandler
{

    // Variables to store the path and the filenames in the directory.
    private string _savePath= ".\\Goals\\";

    private string[] _files;


    // Constructor to set up the class.
    public FileHandler()
    {
        // Set the save path as "./goals."
        SetSavePath();
        // Add the filenames to the _files variable.
        if(Directory.Exists(_savePath))
        {
            _files =  Directory.GetFiles(_savePath);
        }
    }
    // Set the save path based on the operatinting system. On Windows use backslashes.  On unix and other systems, use forward slashes. 
    private void SetSavePath()
    {
        // Figure out what operating system the user is using.
        switch(Environment.OSVersion.Platform){
            case PlatformID.Win32NT:
                // Use a Windows path.
                _savePath= $".\\goals\\";
                break;
            case PlatformID.Unix:
                // Use a unix path.
                _savePath = $"./goals/";
                break;
            default:
                // Use a unix path.
                _savePath= $"./goals/s";
                break;
        }

        // // Create the new directory if the file does not exist.

        if(!Directory.Exists(_savePath))
        {
            Directory.CreateDirectory(_savePath);
        }
        
    }
    // Checks a file name for ".txt" and appends if it does not contain ".txt."
    public string CheckNameForTxt(string fileName)
    {
        // Check if the fileName contains ".txt."
        if(!fileName.Contains(".txt"))
        {
            // If it does not, append ."txt" to the end.
            fileName = fileName + ".txt";
        }

        // Return the fileName with ".txt."
        return fileName;
    }
    
    // List all the exsiting goals that the user has created.  
    public bool ShowGoalFiles()
    {
        
        // Check to see if there are any saved files.
        if(!Directory.Exists(_savePath))
        {   
            // if not exit with a false.
            return false;
        }else
        {     
            // if it does exist, get all the file names and display them on the console.
            foreach(string file in _files)
            {
                if(file.Contains(".txt"))
                {
                    if(System.IO.File.Exists(file))
                    {
                        Console.WriteLine(file);
                    }else
                    {
                            Console.WriteLine($"File: {file}, not found!");
                    }
                }
            }
        }
        // Tell the program that ther are files through a boolean.
        return true;
    }


    // Save the goal in a new or existing file.
    public void SaveFile(string name, string goalDetails)
    {

        // Save a file in the .\goals\ directory
        string fileName = _savePath + CheckNameForTxt(name);



        // // Create a new file writer class to write to the new file.
        using(StreamWriter storeGoalFile = new StreamWriter(fileName))
        {
        // Add each part of the goal to the file. 
            storeGoalFile.WriteLine(goalDetails);
        }
        
    }

    // Load a file in to a list.
    public int LoadFile(string fileName, List<Goal> goals)
    {
    
	
        int totalPoints = 0;
    //     // Check to make sure the file is a ".txt" file.
        fileName = CheckNameForTxt(fileName);

        fileName = _savePath + fileName;
        // Create a file reader class to access the file.
        if(System.IO.File.Exists(fileName))
        {
        string[] fileLines = System.IO.File.ReadAllLines(fileName);
            
            // Iterate through each line and add it as a goal to the list of goals.
            for(int index = 0; index < fileLines.Count(); index++)
            {
                // The first line of the file stores the number of points for those goals.
                // If the line is not the first one save it as a goal.
                if(index != 0)
                {
                    // Seperate the line in parts based off of the spaces.
                    // The basic format is: 
                    // Type: goalTpe Goal: goal   Description: Description Completed: True/False Points: number of Points
                    string[] goalParts = fileLines[index].Split(" ");

                    // Get the type of file
                    string type = goalParts[1];

                    // Get the goal name.  Keep adding words until the description is the next word in the list.
                    string goalName = "";
                    int storeIndex = 0;
                    for(int i = 3 ; i < goalParts.Count() - 1;i++)
                    {
                        // If the current word is not "Description:" than add the word.
                        if(!goalParts[i].Contains("Description:"))
                        {
                            if(i == 0)
                            {
                                goalName = goalName + goalParts[i];
                            }else
                            {
                                goalName = goalName + goalParts[i] + " ";
                            }
                        }else
                        {
                            // else store the current index for the next bits of information.
                            storeIndex = i + 1;
                            break;
                        }
                    }


                    // Repeat the last step for the descrition.
                    string description = "";
                    for(int i = storeIndex; i < goalParts.Count() - 1;i++)
                    {

                        if(!goalParts[i].Contains("Completed:"))
                        {
                            if(i == 0)
                            {
                                description = description + goalParts[i];
                            }else
                            {
                                description = description + " " + goalParts[i];
                            }
                        }else
                        {
                            storeIndex = i + 1;
                            break;
                        }
                    }

                    // Get the true or false value form the goal, to see if it is completed.
                    string finished = goalParts[storeIndex];


                    // Get the number of points the goal is worth.
                    int points = int.Parse(goalParts[storeIndex + 2]);

                    // Depending on the type of the goal add different things differently.
                    switch(goalParts[1])
                    {
                        // If it is a simple goal, set all appropriate variable throuth the setters.
                        case "simple":
                            SimpleGoal newGoal = new SimpleGoal();
                            newGoal.SetType(type);
                            newGoal.SetGoalName(goalName);
                            newGoal.SetDescription(description);
                            // If the goal is unfinished set the goal to unfinished.
                            if(finished.ToLower() == "false")
                            {
                                newGoal.Unfinished(false);
                            }else
                            {
                                // Else set it to finished.
                                newGoal.Unfinished(true);
                            }

                        
                            newGoal.SetPoints(points);
                            goals.Add(newGoal);
                            break;
                            
                        case "eternal":

                            // Same as above except for eternal goals.
                            EternalGoal newEternalGoal = new EternalGoal();
                            newEternalGoal.SetType(type);
                            newEternalGoal.SetGoalName(goalName);
                            newEternalGoal.SetDescription(description);
                            if(finished.ToLower() == "false")
                            {
                                newEternalGoal.Unfinished(false);
                            }
                            newEternalGoal.SetPoints(points);

                            // Set eternal goals specific variables.
                            newEternalGoal.SetTimes(int.Parse(goalParts[storeIndex + 4]));
                            newEternalGoal.SetRandBonus(int.Parse(goalParts[storeIndex + 6]));

                            goals.Add(newEternalGoal);
                            break;
                            
                        case "checklist":

                            // Dito
                            ChecklistGoal newChecklistGoal = new ChecklistGoal();
                            newChecklistGoal.SetType(type);
                            newChecklistGoal.SetGoalName(goalName);
                            newChecklistGoal.SetDescription(description);
                            if(finished.ToLower() == "false")
                            {
                                newChecklistGoal.Unfinished(false);
                            }else
                            {
                                newChecklistGoal.Unfinished(true);
                            }
                            newChecklistGoal.SetPoints(points);
                            // Set Checklist speicific variables.
                            newChecklistGoal.SetCompletedTimes(int.Parse(goalParts[storeIndex + 4]));
                            newChecklistGoal.SetTimes(int.Parse(goalParts[storeIndex + 6]));
                            newChecklistGoal.SetBonus(int.Parse(goalParts[storeIndex + 8]));

                            goals.Add(newChecklistGoal);                        
                            break;
                        default:
                            break;

                    }
                }else
                {
                    // Else get the points the user has with these goals.
                    string[] parts = fileLines[index].Split(" ");
                    totalPoints = int.Parse(parts[1]);
                }

            }

        }else
        {
            // If the file does not exist, inform the user.
            Console.WriteLine($"The file {fileName} does not exist!");
        }   

        // Return the number of points the user has from completed goals.
        return totalPoints;
    }
    

}
