using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
    
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, enter 0 when finished. ");
        int newNumber = -1;
        while(newNumber != 0)
        {

            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());
            if(newNumber != 0)
            {
                numbers.Add(newNumber);

            }



        }

        numbers.Sort();

        int total = 0;
        int lowestPositiveNumber = int.MaxValue;
        foreach(int number in numbers)
        {
            if(number < lowestPositiveNumber && number > 0 )
            {
                lowestPositiveNumber = number;
            }
            total += number; 
        }

        float avg = (float)total / (float)numbers.Count;

        Console.WriteLine($"The highest number is: {numbers[^1]}.");
        Console.WriteLine($"The average number is: {avg}.");
        Console.WriteLine($"The lowest positive number is: {lowestPositiveNumber}.");
        Console.WriteLine($"The total is: {total}");


        Console.WriteLine("Sorted List:");
        foreach(int number in numbers)
        {
            Console.WriteLine($"The number is: {number}");
        }

        
    }
}