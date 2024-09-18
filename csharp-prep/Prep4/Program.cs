using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // List of numbers to store numbers entered in by the user.
        List<int> numbers = new List<int>();


        // Ask the user to enter numbers and declare a varible to store the newest number in.
        Console.WriteLine("Enter a list of numbers, enter 0 when finished. ");
        int newNumber = -1;

        // Let the user enter numbers so long as he or she does not enter 0.
        while(newNumber != 0)
        {
            
            // Prompt the user for a number and store it in a varible. 
            Console.Write("Enter a number: ");
            newNumber = int.Parse(Console.ReadLine());

            // If the number is not 0, add it to the list.
            if(newNumber != 0)
            {
                numbers.Add(newNumber);
            }



        }

        // Sort the list of numbers from lowest to highest.
        numbers.Sort();

        int total = 0;
        int lowestPositiveNumber = int.MaxValue;

        // Add up the total and find the lowest number.
        foreach(int number in numbers)
        {
            // Check to see if the current number is lower than the last lowest number and positive.
            if(number < lowestPositiveNumber && number > 0 )
            {
                lowestPositiveNumber = number;
            }
            // Add the number to the total.
            total += number; 
        }

        // Calculate the average and store it in a varible.
        float avg = (float)total / (float)numbers.Count;

        // Print out the highest number, lowest number, average, and sum of the numbers entered by the user. 
        Console.WriteLine($"The highest number is: {numbers[^1]}.");
        Console.WriteLine($"The average number is: {avg}.");
        Console.WriteLine($"The lowest positive number is: {lowestPositiveNumber}.");
        Console.WriteLine($"The total is: {total}");

        // Print out the list after it has been sorted.
        Console.WriteLine("Sorted List:");
        foreach(int number in numbers)
        {
            Console.WriteLine($"The number is: {number}");
        }

        
    }
}