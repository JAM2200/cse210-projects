class Shape
{
	// Variable to store the color of the shape.
	private string _color = "";
	

	// Constructor that sets the color variable to the color passed in.
	public Shape(string color)
	{
		_color = color;
	}

	// Empty constructor.
	public Shape()
	{
	}
	// Return the color variable.
	public string GetColor()
	{
		return _color;
	}

	// Set the color variable.
	public void SetColor(string color)
	{
		_color = color;
	}
	

	// Create a function to get the area of the shape.
	public virtual double GetArea()
	{
		return 0;
	}
}
