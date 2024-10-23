class SquareShape : Shape
{
	// Create a variable to store the width of the square.
	private double _width; 

	// Create an empty constructor just in case.
	public SquareShape()
	{
	}

	// Initialize the width of the square. And the color through the base constructor. 
	public SquareShape(double width, string color) : base(color)
	{
		_width = width;
	}
	
	// Return the width of the object.
	public double GetWidth()
	{ 
		return _width;
	}
	
	// Set or change the width of the square.
	public void SetWidth(double width)
	{
		_width = width;
	}


	// override the GetArea base function and return the area of the square. 
	public override double  GetArea()
	{
		return _width * _width;
	}


}
