class Reference
{
	private string _book;
	private int _chapter;
	private int _verse;
	private int _endVerse = -1;

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
}

