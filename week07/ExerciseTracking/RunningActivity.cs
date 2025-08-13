public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public override string GetName()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }

    
}