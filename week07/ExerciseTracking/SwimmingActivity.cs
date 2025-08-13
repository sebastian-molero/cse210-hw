public class SwimmingActivity : Activity
{
    private int _laps;
    public SwimmingActivity(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override string GetName()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        const double mtPerLap = 50;
        double miles = (_laps * mtPerLap) * 0.000621371;

        return miles;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return (GetLength() / GetDistance());
    }
}