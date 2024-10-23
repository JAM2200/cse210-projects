class RectangleShape : Shape
{
	// Create variables to store the width and length of the rectangle.
	private double _length; 
	private double _width; 

	// Create an empty constructor just in case.
	public RectangleShape()
	{
	}

	// Set the length and the width, and set the color through the base constructor as well.
	public RectangleShape(double len, double width,string color) :	base(color)
	{
		_length = len;
		_width = width;
	}
	
	// Return the length of the rectangle.
	public double GetLength()
	{ 
		return _length;
	}
	
	// Set the length of the rectangle.
	public void SetLength(double length)
	{
		_length = length;
	}

	// Return the width of the rectangle.
	public double GetWidth()
	{ 
		return _width;
	}
	
	// Set the width of the rectangle.
	public void SetWidth(double width)
	{
		_width= width;
	}

	// Override the base GetArea method and return the area of the rectangle. 
	public override double GetArea()
	{
		return _length * _width;
	}

}
