using System.Data;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class NewVerse
{
    private string _book = "";
	private int _chapter  = 0;
	private int _verse = 0;
	private int _endVerse = -1;
    private Reference _ref = new Reference();

    private string _verseContents = "";

    private void CreateBookName()
    {
        Console.Write("Enter the name of the book: " );
        _book = Console.ReadLine();
    }   
    private void CreateChapter()
    {
        Console.Write("Enter the chapter number: " );
        string input = Console.ReadLine();
        if(input != "")
        {
            _chapter = int.Parse(input);
        }
    }   
    private void CreateVerseNumber()
    {
        Console.Write("Enter the verse number: " );
        
        _verse = int.Parse(Console.ReadLine());
    }   
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

    private void CreateVerseContents()
    {
        Console.Write("Enter the verse: ");
        _verseContents = Console.ReadLine();
    }

    public string GetVerseContents()
    {
        return _verseContents;
    }

    public void CreateVerse()
    {
        CreateBookName();
        CreateChapter();
        CreateVerseNumber();
        CreateEndVerseNumber();
        CreateVerseContents();
        CreateReference();

    }   

    private void CreateReference()
    {
        _ref = new Reference(_book,_chapter,_verse,_endVerse);
    }

    public Reference GetReference()
    {
        return _ref;
    }



}