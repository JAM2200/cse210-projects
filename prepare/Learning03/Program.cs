using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Test each of the fraction constructors.
        // No Argments.
        Fraction fraction1 = new Fraction();
        // One argument for the numerator.
        Fraction fraction2 = new Fraction(7);
        // Two Arguements, one for the numberator and the other for the denominator. 
        Fraction fraction3 = new Fraction(3,5);

        // Display each fraction as a fractional number.
        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction2 = {fraction2.GetFractionString()}");
        Console.WriteLine($"fraction3 = {fraction3.GetFractionString()}");

        // Verify that the setter functions work.
        fraction1.SetTop(5);
        fraction1.SetBottom(7);
        
        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");

        // Test different numbers with the setter functions.
        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");
        
        fraction1.SetTop(1);
        fraction1.SetBottom(3);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");


        // Verify that the getter functions work.  Get the top and display it to the console.  Than get the bottom and display it to 
        // the console. 
        Console.WriteLine($"fraction1._topNumber = {fraction1.GetTop()}");
        Console.WriteLine($"fraction1._bottomNumber = {fraction1.GetBottom()}");

    }
}