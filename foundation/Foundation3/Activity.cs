abstract class Activity 
{

    // Define a base activity that store variables for the rate a person is doing an activity.
    // Create a variable to store the persons pace, and how many minutes they have been
    // performing the activity.
    private float _speed = 0;
    private float _pace = 0;

    private float _minutes = 0;

    // Set the minutes in the constructor.
    public Activity(float minutes)
    {
        _minutes = minutes;
    }

    // Create a variable for the current time.
    private DateTime _date = DateTime.Now;

    // Get the current date and time in a string.
    protected string GetCurrentDate()
    {
        return _date.ToString("dd MMM, yyyy");
    }
    

    // Return the number of minutes the person is doing the activity. 
    protected float GetMinutes()
    {
        return _minutes;
    }


    // Declare a function to return the distance in child activities. 
    protected abstract float GetDistance();

    // Return the speed the person is doing an activity at.  In miles per hour.
    protected virtual float GetSpeed()
    {
        return _speed;
    }

    // Set the speed of the activity.
    protected void SetSpeed(float speed)
    {
        _speed = speed;
    }

    // Return the pace of the activity in minutes.
    protected virtual float GetPace()
    {
        return _pace;
    } 

    // Set the pace of the activity in minutes.
    protected virtual void SetPace(float pace)
    {
        _pace = pace;
    }



    // Declare a variable to get a summary of a persons activiy in the format of "date activity, speed, pace." 
    public abstract string GetSummary();
}