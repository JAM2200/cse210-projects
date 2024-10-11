class Comment
{
	private string _comment = "";
	private string _name = "";
	
	public Comment(string name,string comment)
	{
		_name = name;
		_comment = comment;
	}

	public void Display()
	{
		Console.WriteLine($"Comment by {_name}: {_comment}");
	}
}
