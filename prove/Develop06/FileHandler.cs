using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
public class FileHandler
{

    private string _savePath= ".\\Goals\\";
    private string _subDirectory = "";
    private string[] _files;


    public FileHandler(string goalType)
    {
        _subDirectory = goalType;
        SetSavePath();
            _files = Directory.GetFiles(_savePath);
    }
    // Set the save path based on the operatinting system. On Windows use backslashes.  On unix and other systems, use forward slashes. 
    private void SetSavePath()
    {
        // Figure out what operating system the user is using.
        switch(Environment.OSVersion.Platform){
            case PlatformID.Win32NT:
                // Use a Windows path.
                _savePath= $".\\Goals\\{_subDirectory}\\";
                break;
            case PlatformID.Unix:
                // Use a unix path.
                _savePath = $"./Goals/{_subDirectory}/";
                break;
            default:
                // Use a unix path.
                _savePath= $"./Goals/{_subDirectory}/";
                break;
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
    
    // List all the exsiting verses that the user has created.  
    // Not part of the core requirements.
    public bool ShowGoals()
    {
        
        // Check to see if there are any saved files.
        if(!Directory.Exists(_savePath))
        {   
            // if not exit with a false.
            return false;
        }else
        {     
            // if it does exsist, get all the file names and display them on the console.
	    int goalNumber = 1;

            foreach(string file in _files)
            {
                if(file.Contains(".txt"))
                {
        		if(System.IO.File.Exists(file))
        		{
				Console.Write($"{goalNumber}. ");
            			string[] fileLines = System.IO.File.ReadAllLines(file);
	    			Console.WriteLine(fileLines[1].Replace("Goal: ","" ));
	    			Console.WriteLine(fileLines[2].Replace("Description: ","\t" ));

	        	}else
       		 	{
            			Console.WriteLine($"File: {file}, not found!");
        		}
                }
		goalNumber++;
            }
        }
        // Tell the program that ther are files through a boolean.
        return true;
    }


    // Save the verse in a new or existing file.
    public void SaveFile(string name, string goalDetails)
    {


        // Console.WriteLine(_savePath);
        // Check if the file name is a ".txt" file.

        // Save a file in the .\verses\ directory
        string fileName = _savePath + CheckNameForTxt(name);

        // // Create the new directory if the file does not exist.
        if(!Directory.Exists(_savePath))
        {
            Directory.CreateDirectory(_savePath);
        }

        // // Create a new file writer class to write to the new file.
        using(StreamWriter storeVerseFile = new StreamWriter(fileName))
        {
        // Add each part of the goal to the file. 
            storeVerseFile.WriteLine(goalDetails);
        }
        
    }

    // Load a file in to a list.
    public void LoadFile( Goal goal, int goalNumber)
    {
	    string fileName = "Enter a number by a goal that you have.  Otherwise it won't load";
	if(goalNumber < _files.Count())
	{

		fileName = _files[goalNumber - 1]; 
	}
	
	
        // Check to make sure the file is a ".txt" file.
        fileName = CheckNameForTxt(fileName);
        // Create a file reader class to access the file.

        if(System.IO.File.Exists(fileName))
        {
            string[] fileLines = System.IO.File.ReadAllLines(fileName);
        
        
	    goal.SetType(fileLines[0].Replace("Type: ","" ));
	   goal.SetGoal(fileLines[1].Replace("Goal: ","" ));
	   goal.SetDescription(fileLines[2].Replace("Description: ","" ));

	   //if(_subDirectory == "checklist")
	   //{
		  
		   // goal.SetType(fileLines[0]);
	   // goal.SetGoal(fileLines[1]);
	   // goal.SetDescription(fileLines[2]);

        }else
        {
            Console.WriteLine($"File: {fileName}, not found!");
        }

    }
    

}
