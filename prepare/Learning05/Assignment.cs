class Assignment
{
	// This class is the parent class to be used in child classes.
	
	// Create variables to store the name of the student and 
	// the topic.
	private string _studentName = "";
	private string _topic = "";

	// Create an empty constructor just in case.
	// Set the variables to "Unknown."
	public Assignment()
	{
		_studentName = "No information";
		_topic = "Unknown";
	}
	
	// Create a constructor to initialize the variables.
	public Assignment(string studentName, string topic)
	{
		_studentName = studentName;
		_topic = topic;
	}

	// Getter for student name as a string.
	public string GetStudentName()
	{
		return _studentName;
	}

	// Set the student name.
	public void SetStudentName(string name)
	{
		_studentName = name;
	}
	
	// Getter for the topic.
	public string GetTopic()
	{
		return _topic;
	}

	// Setter for the topic.
	public void SetTopic(string topic)
	{
		_topic = topic;
	}

	// Return the assignment information in the form of:
	// "student name - topic."
	public string GetSummary()
	{
		return $"{_studentName} - {_topic}";
	}
}


