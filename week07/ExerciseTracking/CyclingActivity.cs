public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override string GetName()
    {
        return "Cycling";
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}