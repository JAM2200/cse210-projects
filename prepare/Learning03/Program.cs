using System;

class Program
{
    
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(7);
        Fraction fraction3 = new Fraction(3,5);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction2 = {fraction2.GetFractionString()}");
        Console.WriteLine($"fraction3 = {fraction3.GetFractionString()}");

        fraction1.SetTop(5);
        fraction1.SetBottom(7);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");


        fraction1.SetTop(3);
        fraction1.SetBottom(4);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");
        
        fraction1.SetTop(1);
        fraction1.SetBottom(3);

        Console.WriteLine($"fraction1 = {fraction1.GetFractionString()}");
        Console.WriteLine($"fraction1 = {fraction1.GetFractionDecimal()}");

    }
}