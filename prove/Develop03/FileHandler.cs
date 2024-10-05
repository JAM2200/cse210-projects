using System.ComponentModel;
using System.IO;
public class FileHandler
{

    private string _savePath= ".\\verses\\";

    private void SetSavePath()
    {

        switch(Environment.OSVersion.Platform){
            case PlatformID.Win32NT:
                _savePath= ".\\verses\\";
                break;
            case PlatformID.Unix:
                _savePath= "./verses/";
                break;
            default:
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
    public void ListVerses()
    {

        if(!Directory.Exists(_savePath))
        {
            Console.WriteLine("No verses created yet.");
        }else
        {     

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
    }


    // Save the verse in a new or existing file.
    public void SaveFile(string fileName,string verse, Reference scriptureReference)
    {

        SetSavePath();

        Console.WriteLine(_savePath);
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
        //     // Add each part of the reference to the file, and the verse.
            
                    storeVerseFile.WriteLine(scriptureReference.GetBook());
                    storeVerseFile.WriteLine(scriptureReference.GetChapter());
                    storeVerseFile.WriteLine(scriptureReference.GetVerse());
                    storeVerseFile.WriteLine(scriptureReference.GetEndVerse());
                    storeVerseFile.WriteLine(verse);
        }
        
    }

    // Load a file in to a list.
    public void LoadFile(string fileName, List<string> fileContents)
    {
        // Check to make sure the file is a ".txt" file.
        fileName = _savePath + CheckNameForTxt(fileName);
        // Create a file reader class to access the file.
        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        // Go through each line in the file. 
        for(int line = 0;line < fileLines.Count();line++)
        {
            fileContents.Add(fileLines[line]);                
        }

      
        
        
    }
    

}