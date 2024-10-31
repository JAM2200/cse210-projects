class RunningActivity : Activity
{

    
    // Create a variable to store the distance travled.
    private float _distance = 0;

    // Pass minutes to the base constructor and initialize the distance through the constructor.
    public RunningActivity(float distance, float minutes) : base(minutes)
    {
        _distance = distance;
    }

    // Return the distance travled.
    protected override float GetDistance()
    {
        return _distance;
    }

    // Get the speed of a person running.
    protected override float GetSpeed()
    {   
        // Make sure that the program is not goin to divide by 0.
        if(base.GetMinutes() != 0)
        {
            return _distance / base.GetMinutes() * 60;
        }else
        {
            return 0;
        }
    }


    // rt = d

    // Return the pace of the runner.
    protected override float GetPace()
    {
            return GetSpeed() / 60;
    }


    // Create a summary of the activity.
    public override string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        float minutes = base.GetMinutes();
        return $"{GetCurrentDate()} Running ({minutes:0.00})- Distance: {distance:0.00} miles, Speed {speed:0.00} mph, Pace {pace:0.00} mile(s) per minute(s).";
    }
}