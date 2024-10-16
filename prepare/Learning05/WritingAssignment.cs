class WritingAssignment : Assignment
{
	
	// Create a variable to store the title of an assignment.
	private string _title = "";

	// Create an empty constructor just in case.  Set the title to 
	// "Unknown."
	public WritingAssignment() : base()
	{
		_title = "Unknown";
	}
	
	// Constructor to initialize all the variables.  Use the base 
	// constructor instead of using the setter methods.
	public WritingAssignment(string name, string topic,string title): base(name,topic)
	{
		_title = title;
	}

	// Method to set the title.
	public void SetTitle(string title)
	{
		_title = title;
	}
	

	// Return the title as a string.
	public string GetTitle()
	{
		return _title;
	}

	// return the assingment information in the 
	// form of: "Some Title by student name."
	public string GetWritingInformation()
	{
		return $"{_title} by {GetStudentName()}";
	}
	

}
