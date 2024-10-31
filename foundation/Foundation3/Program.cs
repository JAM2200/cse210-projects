using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity(30,45);

        SwimmingActivity swimmingActivity = new SwimmingActivity(50,30);

        BicycleActivity bicycleActivity = new BicycleActivity(45,10);

        List<Activity> activities = new List<Activity>();


        activities.Add(runningActivity);
        activities.Add(swimmingActivity);
        activities.Add(bicycleActivity);

        foreach(Activity activity in activities)
        {
            DisplayActivityDetails(activity);
        }
    }

    static void DisplayActivityDetails(Activity activity)
    {
        Console.WriteLine(activity.GetSummary());
    }

    
}