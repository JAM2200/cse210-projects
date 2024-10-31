class BicycleActivity : Activity
{

    private float _speed = 0;

    public BicycleActivity(float minutes,float speed) : base(minutes)
    {
        _speed = speed;
    }

    protected override float GetDistance()
    {
        return  _speed * GetMinutes() / 60;
    }

    protected override float GetSpeed()
    {
        return _speed;
    }

    protected override float GetPace()
    {
            return GetSpeed() / 60;
    }


    public override string GetSummary()
    {
        float distance = GetDistance();
        float speed = GetSpeed();
        float pace = GetPace();
        float minutes = GetMinutes();
        return $"{GetCurrentDate()} Stationary Bicycle: ({minutes:0.0})- Distance: {distance} miles, Speed {speed:0.00} mph, Pace {pace:0.00} mile(s) per minute(s).";
    }
}