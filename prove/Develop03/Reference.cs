 public class Reference
{

	// Create variables to store the book name, chpater number, starting verse number, and ending verse number.
	private string _book = "";
	private int _chapter = 0;
	private int _verse = 0;
	private int _endVerse = -1;

	// Create an empty constructor, so that the programmer may declare a reference object.
	public Reference(){}
	// Declare a constructor that takes arguments for the book name, chapter number, and starting verse number.
	public Reference(string book, int chapter, int verse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
	}
	// Declare a constructor that takes arguments for the book name, chapter number, starting verse number, and ending verse number.

	public Reference(string book, int chapter, int verse,int endVerse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
		_endVerse = endVerse;
	}
	
	// Create a method to display the reference in the format of "Book x:x-x" or "Book x:x" depending on whether there is a 
	// ending verse or not. 
	public void DisplayRef()
	{
		if(_endVerse != -1)
		{
			Console.Write($"{_book} {_chapter}:{_verse}-{_endVerse} ");
		}else
		{

			Console.Write($"{_book} {_chapter}:{_verse} ");
		}
	}

	// Return the _book variable to the program.
	public string GetBook()
	{
		return _book;
	}

	// Return the _chapter variable to the program.

	public int GetChapter()
	{
		return _chapter;
	}
	// Return the staring verse number to the program.

	public int GetVerse()
	{
		return _verse;
	}

	// Return the ending verse number to the program.

	public int GetEndVerse()
	{
		return _endVerse;
	}
}

