class Word
{
	// Create varibles to store the word and the appropriate number of underscore, equal to the length of the word.
	// Also create a variable to store whether the word should be hidden.
	private bool  _isHidden = false;
	private string _word = "";
	private string _underscores = "";

	//  Constructor to set the object up with a word and a equivalent length string of underscores.
	public Word(string word)
	{
		_word = word;
		
		// Get the length of the word and add an underscore to _underscore for each character in word.
		for(int i = 0; i < _word.Count();i++)
		{
			_underscores = _underscores + "_";		
		}
		// Set isHidden to false so that it is not accidently hidden at first.
		_isHidden = false;
	}
	// Display the word or if it is hidden underscores.
	public void Display()
	{

		if(_isHidden)
		{
			Console.Write(_underscores);
		}else
		{
			Console.Write(_word);
		}
	}
	
	// Set the word to be hidden when displayed.
	public void Hide()
	{
		_isHidden = true;
	}

	// Return whether the word is hidden.
	public bool Hidden()
	{
		return _isHidden;
	}
	// Change the value of the word.  Otherwise the same as the constructor.
	public void ChangeWord(string word)
	{
		_word = word;
		for(int i = 0; i < _word.Count();i++)
		{
			_underscores = _underscores + "_";		
		}
	}
}
