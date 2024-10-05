class Scripture
{
	// Set up varibles for storing words from a scripture, a scripture reference, whether all words are hidden,
	// and other variables pertinent varibles.
	private List<Word> _words = new List<Word>();
	private bool _allHidden = false;
	private int _numberOfHiddenWords = 2;
	private int _numberOfWordsToHide = 2;
	private Reference reference;

	// Constructor that accepts a verse as a string and a scriptrure reference.
	public Scripture(string verse, Reference scriptureReference)
	{
		// Store the passed reference in class.
		reference = scriptureReference; 
		// Create an array of from the verse		
		string[] _storeWords = verse.Split(' '); 
		for(int i = 0; i < _storeWords.Count();i++)
		{
			// Add the words to the list of words as Word objects.
			Word newWord = new Word(_storeWords[i]);
			_words.Add(newWord);
		}
	}

	// Empty constructor
	public Scripture()
	{
	}

	// Same as the constructor.  Gives the programmer the option to use an empty constructor if preffered.
	public void SetVerseAndScripture(string verse, Reference scriptureReference)
	{
		// Store the passed reference in class.
		reference = scriptureReference; 
		// Create an array of from the verse		
		string[] _storeWords = verse.Split(' '); 
		for(int i = 0; i < _storeWords.Count();i++)
		{
			// Add the words to the list of words as Word objects.
			Word newWord = new Word(_storeWords[i]);
			_words.Add(newWord);
		}
	}

	// Print out all the words in the verse with a space after each word.
	private void DisplayScripture()
	{	
		// Display the reference to the screen.
		reference.DisplayRef();
		// Iterate through each word and display it to the screen with a space afterwards.
		for(int i = 0; i < _words.Count();i++)
		{
			_words[i].Display();
			Console.Write(" ");
		}
	}

	// Randomly choose two new words to hide from the user.
	private void UpdateHiddenWords()
	{
		// Placed in a for loop to make the code more reuasable.
		for(int wordToHide = 0; wordToHide < _numberOfWordsToHide;wordToHide++)
		{
			// Create a random number generator and create a random index of a word to hide.
			Random newHiddenWord = new Random();
			int wordIndex = newHiddenWord.Next(0,_words.Count() );

			// Check to see if the word with the random index is hidden already.
			if(!_words[wordIndex].Hidden())
			{
				// If it is not hidden hide it.
				_words[wordIndex].Hide();
			}else 
			{
				// If the word is hiddne start counting how many words are hidden.
				_numberOfHiddenWords = 0;
				// Add one to the random index and store it in a different index.
				int checkIfHiddenIndex = wordIndex + 1;

				// Check if the index is bigger than the list of words.  If it is set equal to the first index.
				if(checkIfHiddenIndex == _words.Count())
				{
					checkIfHiddenIndex = 0;
				}

				//  Got through every word in the list of _words to see if it is hidden. if it is no t, hide it. Else check the next one and see if it needs to be hidden.
				// Keep iterating through the list until a word is hidden or there are no words to hide. 
				for(int j = 0; j < _words.Count();j++)
				{
					// Check if the word is hidden.
					if(_words[checkIfHiddenIndex].Hidden())
					{
						// If it is add one to both the index and number of hidden words.
						_numberOfHiddenWords++;
						checkIfHiddenIndex++;

						// Make sure the index does not go out of range.
						if(checkIfHiddenIndex == _words.Count())
						{
							// If the index is out of range set equal to the first index.
							checkIfHiddenIndex = 0;
						}
					}else
					{
						// If the word is not hidden then hide and go to the next iteration.
						_words[checkIfHiddenIndex].Hide();
						break;
					}
					
					// If all the words are hidden then break out out of the loop.:w

					if(_numberOfHiddenWords == _words.Count())
					{
						break;
					}
				}
			}

		}
		
	}

	// Memorize the verse of scripture.
	public void Memorize()
	{
		// While all the words are not hidden.
		while(!_allHidden)
		{
			// Clear the console, and display the scripture.
			Console.Clear();
			DisplayScripture();

			// Prompt the user to quit or continure memorizing.
			Console.Write("\n\nPress enter to continue or type \"quit\" to exit: ");
			
			// If all the words are hidden end the program after the user pushes the enter key.
			if(_numberOfHiddenWords == _words.Count())
			{
				_allHidden = true;
			}

			// If the user typed "quit" exit the program.
			string quit = Console.ReadLine();
			if(quit.ToLower() == "quit")
			{
				_allHidden = true;
			}

			// Hide a few more words.
			UpdateHiddenWords();
		}

	}
}
