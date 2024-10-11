class Video
{
	private string _title;
	private string _author;
	private List<Comment> _comments = new List<Comment>();
	private float _length; 

	public Video(string name,string author,float length)
	{
		_title = name;
		_author = author;
		_length = length;
	}

	public void DisplayInfo()
	{
		Console.WriteLine($"Video: {_title}, Author: {_author}, Length: {_length} Comments: {_comments.Count()}");
		foreach(Comment commentor in _comments)
		{
			commentor.Display();					
		}
	}

	public int GetNumberOfComments()
	{
		return _comments.Count();
	}

	public void NewComment(string name,string comment)
	{
		Comment newComment = new Comment(name,comment);
		_comments.Add(newComment);
	}


}
