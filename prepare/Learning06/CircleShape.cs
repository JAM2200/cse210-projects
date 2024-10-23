class CircleShape : Shape
{
	private double _radius;

	// Empty constructor.
	public CircleShape()
	{
	}

	// Constructor that initializes the radius with a value and sets the color of the 
	// circle using the base constructor.
	public CircleShape(double rad, string color) : base(color)
	{
		_radius = rad;
	}
	
	// Return the radius of the circle.
	public double GetRadius()
	{
		return _radius;
	}

	// Set or change the radius of the circle.
	public void SetRadius(double rad)
	{
		_radius = rad;
	}	
	

	// Override the parent GetArea function and return the area of the circle.
	public override double GetArea()
	{
		return Math.PI * _radius * _radius;
	}
}

