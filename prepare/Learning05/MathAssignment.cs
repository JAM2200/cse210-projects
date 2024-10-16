class MathAssignment : Assignment
{
	private string _textBookSection = "";
	private string _problems = "";
	
	public MathAssignment() : base()
	{
		_textBookSection = "1.0";
		_problems = "1-10";
	}

	public MathAssignment(string studentName,string topic, string problems, string section) : base(studentName,topic)
	{
		_textBookSection = section;
		_problems = problems;
	}

	public void SetSection(string section)
	{
		_textBookSection = section;
	}

	public string GetSection(string section)
	{
		return _textBookSection; 
	}

	public void SetProblems(string problems)
	{
		_problems = problems;
	}

	public string GetProblems()
	{
		return _problems;
	}	

	public string GetHomeworkList() 
	{
		return $"Section: {_textBookSection} Problems: {_problems}"; 
	}


}
