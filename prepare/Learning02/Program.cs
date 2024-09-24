using System;

class Program
{

    static void Main(string[] args)
    {

        // Instantiate a new job object;
        Job job1 = new Job();

        // Initialize its varibles with dot (.) notation.
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2020";
        job1._endYear = "2024";

        // job1.Display();

        // Console.WriteLine($"{job1._jobTitle}");

        // Instaniate a second job object.
        Job job2 = new Job();

        // Initialize the variables with dot notation for later use.
        job2._jobTitle = "Mechanical Engineer";
        job2._company = "Chevy";
        job2._startYear = "2014";
        job2._endYear = "2021";

        // Create a new resume object using the new Class() method;
        Resume resume = new Resume();

        // Add a name to the object.
        resume._name = "John Doe";

        // Fill in the resume with jobs worked.   
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Display the resume on the console.
        resume.Display();

        // Verify that individual job properties can be accesed through the resume object.  
        // Commented out becuase they are not needed in the program. 
        // Console.WriteLine($"{resume._jobs[0]._jobTitle}");
        // Console.WriteLine($"{resume._jobs[1]._jobTitle}");
      
    }
}