using System.ComponentModel;
using System.IO;
public class FileHandler
{

    private string _savePath= ".\\verses\\";
    
    public FileHandler()
    {
	SetSavePath();
    }

    // Set the save path based on the operatinting system. On Windows use backslashes.  On unix and other systems, use forward slashes. 
    private void SetSavePath()
    {
        // Figure out what operating system the user is using.
        switch(Environment.OSVersion.Platform){
            case PlatformID.Win32NT:
                // Use a Windows path.
                _savePath= ".\\verses\\";
                break;
            case PlatformID.Unix:
                // Use a unix path.
                _savePath= "./verses/";
                break;
            default:
                // Use a unix path.
                _savePath= "./verses/";
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
    public bool ListVerses()
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
            
            Console.WriteLine("Your verses: ");
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
    public void SaveFile(string fileName,string verse, Reference scriptureReference)
    {

        // Set the save path to a Windows path or linux/unix path.

        // Console.WriteLine(_savePath);
        // Check if the file name is a ".txt" file.

        // Save a file in the .\verses\ directory
        fileName = _savePath + CheckNameForTxt(fileName);

        // // Create the new directory if the file does not exist.
        if(!Directory.Exists(_savePath))
        {
            Directory.CreateDirectory(_savePath);
        }

        // // Create a new file writer class to write to the new file.
        using(StreamWriter storeVerseFile = new StreamWriter(fileName))
        {
        // Add each part of the reference to the file, and the verse.
            
                    storeVerseFile.WriteLine(scriptureReference.GetBook());
                    storeVerseFile.WriteLine(scriptureReference.GetChapter());
                    storeVerseFile.WriteLine(scriptureReference.GetVerse());
                    storeVerseFile.WriteLine(scriptureReference.GetEndVerse());
                    storeVerseFile.WriteLine(verse);
        }
        
    }

    // Load a file in to a list.
    public string LoadFile(string fileName, List<string> referenceParts)
    {
        // Check to make sure the file is a ".txt" file.
        fileName = _savePath + CheckNameForTxt(fileName);
        // Create a file reader class to access the file.
        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        // Go through each line in the file. Except the last one.
        for(int i = 0;i < fileLines.Count() - 1;i++ )
        {
            referenceParts.Add(fileLines[i]);
        }

        return fileLines[fileLines.Count() - 1];        
    }
    

}
