class MathAssignment : Assignment
{
	private string _textBookSection = "";
	private string _problems = "";
	
	// Empty constructor.  Just in case the varibles need to be initialized later.
	// Set the variables to say "unknown."
	public MathAssignment() : base()
	{
		_textBookSection = "Unknown";
		_problems = "Unknown";
	}

	// Set the variables in the constructor.  Call the base constructor instead of using the setter methods.
	public MathAssignment(string studentName,string topic, string problems, string section) : base(studentName,topic)
	{
		_textBookSection = section;
		_problems = problems;
	}

	// Set the section for the assignment. 
	public void SetSection(string section)
	{
		_textBookSection = section;
	}

	// Return the section as a string.
	public string GetSection(string section)
	{
		return _textBookSection; 
	}

	// Set the math problems as a string.
	public void SetProblems(string problems)
	{
		_problems = problems;
	}
	
	// Return the math problems.
	//
	public string GetProblems()
	{
		return _problems;
	}	

	// Get the homework list in the form of: "Section: x.x Problems: x-x."
	public string GetHomeworkList() 
	{
		return $"Section: {_textBookSection} Problems: {_problems}"; 
	}


}
