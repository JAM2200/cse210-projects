class SwimmingActivity : Activity
{
    // Create variables to store the number of laps a person swims.
    // Also create a variable to store the length of the pool.
    private float _laps = 0;
    private float _poolLength = 50;

    // Set the number of minutes through the base constructor.
    // Set the number of laps swam by a person in the constructor.
    public SwimmingActivity(float minutes,float laps) : base(minutes)
    {
        _laps = laps;
    }

    // Return the distance a person has swam in miles. 
    protected override float GetDistance()
    {
        // The distance is laps times pool length (which is in meters). 
        // Multiply it by 1000 to convert it to kilometers.
        // Finally, multiply by 0.62 to convert to miles.
        return _laps * _poolLength / 1000f * 0.62f;
    }

    //  Get the speed of the swimmer.
    protected override float GetSpeed()
    {
        return GetDistance() / GetMinutes() * 60f;
    }

    // Return the pace of the swimmer.
    protected override float GetPace()
    {
            return GetSpeed() / 60;
    }

    // Return a summary of a swimmers progress.
    public override string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        float minutes = GetMinutes();
        return $"{GetCurrentDate()} Swimming ({minutes:0.0})- Laps: {_laps}, Distance {GetDistance()} mile(s), Speed {speed:0.00} mph, Pace {pace:0.00} mile(s) per minute(s).";
    }
}