using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
public class FileHandler
{

    private string _savePath= ".\\Goals\\";
    private string _subDirectory = "";


    public FileHandler(string goalType)
    {
        _subDirectory = goalType;
        SetSavePath();
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
                _savePath = $"./verses/{_subDirectory}/";
                break;
            default:
                // Use a unix path.
                _savePath= $"./verses/{_subDirectory}/";
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
            string[] files = Directory.GetFiles(_savePath);
            
            Console.WriteLine($"Your {_subDirectory} goals: ");
            foreach(string file in files)
            {
                if(file.Contains(".txt"))
                {
                    Console.WriteLine($"{file.Replace(_savePath, "")}");
                }
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
        // Add each part of the reference to the file, and the verse.
            storeVerseFile.WriteLine(goalDetails);
        }
        
    }

    // Load a file in to a list.
    public void LoadFile(string fileName, List<string> referenceParts)
    {
        // Check to make sure the file is a ".txt" file.
        fileName = _savePath + CheckNameForTxt(fileName);
        // Create a file reader class to access the file.

        if(System.IO.File.Exists(fileName))
        {
            string[] fileLines = System.IO.File.ReadAllLines(fileName);
        
        
            // Go through each line in the file.
            for(int i = 0;i < fileLines.Count();i++ )
            {
                referenceParts.Add(fileLines[i]);
            }

        }else
        {
            Console.WriteLine($"File: {fileName}, not found!");
        }

    }
    

}