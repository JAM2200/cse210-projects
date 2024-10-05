 public class Reference
{
	private string _book = "";
	private int _chapter = 0;
	private int _verse = 0;
	private int _endVerse = -1;

	public Reference(){}
	public Reference(string book, int chapter, int verse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
	}
	public Reference(string book, int chapter, int verse,int endVerse)
	{
		_book = book;
		_chapter = chapter;
		_verse = verse;
		_endVerse = endVerse;
	}
	
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

	public string GetBook()
	{
		return _book;
	}


	public int GetChapter()
	{
		return _chapter;
	}

	public int GetVerse()
	{
		return _verse;
	}


	public int GetEndVerse()
	{
		return _endVerse;
	}
}

