class Comment
{

	// Create varibles to store the comment and the name of the commenter.
	private string _comment = "";
	private string _name = "";
	
	// Assign the commment and name when the constructor is called.
	public Comment(string name,string comment)
	{
		_name = name;
		_comment = comment;
	}

	// Display the comment and the name.
	public void Display()
	{
		Console.WriteLine($"Comment by {_name}: {_comment}");
	}
}
