class Video
{
	// Create variable for the title, and author of the video.  Also create a list of comments and a variable to store the lenght of the video. 
	private string _title;
	private string _author;
	private List<Comment> _comments = new List<Comment>();
	private float _length; 


	// Inittialize the variables when the constructor is called.
	public Video(string name,string author,float length)
	{
		_title = name;
		_author = author;
		_length = length;
	}

	// Print out the variables to the console and iterate through each comment and display it on the console as well.
	public void DisplayInfo()
	{
		Console.WriteLine($"Video: {_title}, Author: {_author}, Length: {_length} Comments: {_comments.Count()}");
		foreach(Comment commentor in _comments)
		{
			commentor.Display();					
		}
	}

	// Return the number of comments.
	private int GetNumberOfComments()
	{
		return _comments.Count();
	}

	// Create a new comment.
	public void NewComment(string name,string comment)
	{
		Comment newComment = new Comment(name,comment);
		_comments.Add(newComment);
	}


}
