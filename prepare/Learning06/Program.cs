using System;

class Program
{
    static void Main(string[] args)
    {
	    // Create a squre shape object and initialize its values.
	    SquareShape sqr = new SquareShape(5, "Blue");

	    // Print out the area of the square and its color.
	    Console.WriteLine(sqr.GetArea());
	    Console.WriteLine(sqr.GetColor());
	    
	    // Create a rectangle shape object.
	    RectangleShape rect = new RectangleShape(5,6, "Green");

	    // Display its area and color.
	    Console.WriteLine(rect.GetArea());
	    Console.WriteLine(rect.GetColor());
	    
	    // Create a circle object.
	    CircleShape circle = new CircleShape(10, "Red");

	    // Display its area and color.
	    Console.WriteLine(circle.GetArea());
	    Console.WriteLine(circle.GetColor());

	    // Creat a list of shapes.
	    List<Shape> shapes = new List<Shape>();


	    // Add all of the shapes objects to the list.
	    shapes.Add(sqr);
	    shapes.Add(rect);
	    shapes.Add(circle);

	    // Itereate through each object in the list and display its area and color.
	    foreach(Shape shape in shapes)
	    {
		    Console.WriteLine($"The area is: {shape.GetArea()}, and the color is: { shape.GetColor()}");
	    }

    }
    

}
