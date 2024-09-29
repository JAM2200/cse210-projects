using System.IO;
public class FileHandler
{

    string _savePath = ".\\journals\\";
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
    
    // List all the exsiting Journals that the user has created.

    public void ListJournals()
    {

        string[] files = Directory.GetFiles(_savePath);
        
        Console.WriteLine("Your Journals: ");
        foreach(string file in files)
        {
            if(file.Contains(".txt"))
            {
                Console.WriteLine($"{file.Replace(_savePath, "")}");
            }
        }
    }


    // Save the journal in a new or existing file.
    public void SaveFile(string fileName, List<string> fileContents)
    {
        // Check if the file name is a ".txt" file.

        // Save a file in the .\journals\ directory
        fileName = _savePath + CheckNameForTxt(fileName);

        // Create the new directory if the file does not exist.
        if(!Directory.Exists(_savePath))
        {
            Directory.CreateDirectory(_savePath);
        }

        // Create a new file writer class to write to the new file.
        using(StreamWriter storeJournalFile = new StreamWriter(fileName))
        {
            // Add each entry to the file, one line at a time.
            foreach(string line in fileContents)
            {
                // Exclude empty new line strings.
                if(line != "\n")
                {
                    storeJournalFile.WriteLine(line);
                }
            }
        }
        
    }

    // Load a file in to a list.
    public void LoadFile(string fileName, List<string> fileContents)
    {
        // Check to make sure the file is a ".txt" file.
        fileName = _savePath + CheckNameForTxt(fileName);
        // Create a file reader class to access the file.
        string[] fileLines = System.IO.File.ReadAllLines(fileName);

        // Create a variable to store one entry.
        string currentEntry = "";
        // Go through each line in the file. 
        for(int lineIndex = 0;lineIndex < fileLines.Count();lineIndex++)
        {
        

                // If the next line in the file contains the string "Date:" add the current entry to the list.
                // And start a new entry. 
                if(fileLines[lineIndex].Contains("Date:"))
                {

                    // Make sure to exlude the first line from being added becuase it is empty.
                    if(lineIndex != 0)
                    {
                        fileContents.Add(currentEntry);
                    }
                    currentEntry = fileLines[lineIndex] + "\n";
                }else{
            
                    // Append the current line to the new entry unless it is just a new line.
                    if( fileLines[lineIndex] != "\n"){
                        currentEntry = currentEntry + fileLines[lineIndex];
                    }
                }

            

        }

        // Add the last entry to the list.
        fileContents.Add(currentEntry);
        
        
    }
    

}