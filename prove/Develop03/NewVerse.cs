using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


// This class is used to create a new verse that the user can save to a file.
class NewVerse
{

    // Create variables to store the book name, chapter number, verse number, last verse number, and the verse. 
    private string _book = "";
	private int _chapter  = 0;
	private int _verse = 0;
	private int _endVerse = -1;
    // Also declare a reerence for later.
    private Reference _ref = new Reference();

    private string _verseContents = "";

    // Prompt the user for the name of the book.
    private void CreateBookName()
    {
        Console.Write("Enter the name of the book: " );
        _book = Console.ReadLine();
    }   
    // Prompt the user for the chapter number.

    private void CreateChapter()
    {
        Console.Write("Enter the chapter number: " );
        string input = Console.ReadLine();
        if(input != "")
        {
            _chapter = int.Parse(input);
        }
    }   
    // Prompt the user for the verse number.

    private void CreateVerseNumber()
    {
        Console.Write("Enter the verse number: " );
        
        _verse = int.Parse(Console.ReadLine());
    }   
    // Prompt the user for the last verse number.

    private void CreateEndVerseNumber()
    {
        Console.Write("Enter the last verse number (if entering more than one verse, otherwise hit enter): " );
        
        string getLastVerse = Console.ReadLine();
        if(getLastVerse != "")
        {
            _endVerse = int.Parse(getLastVerse);
        }else
        {
            _endVerse = -1;
        }        
    }
    

    // Prompt the user for the verse words.
    private void CreateVerseContents()
    {
        Console.Write("Enter the verse: ");
        _verseContents = Console.ReadLine();
    }

    // Return the verse numbers to the program.
    public string GetVerseContents()
    {
        return _verseContents;
    }

    // Create a verse.
    public void CreateVerse()
    {
        CreateBookName();
        CreateChapter();
        CreateVerseNumber();
        CreateEndVerseNumber();
        CreateVerseContents();
        CreateReference();

    }   

    // Turn the information to a scripture refence.
    private void CreateReference()
    {
        _ref = new Reference(_book,_chapter,_verse,_endVerse);
    }
    // Return the reference to the program.
    public Reference GetReference()
    {
        return _ref;
    }



}