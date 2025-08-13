public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public abstract string GetName();

    public int GetLength()
    {
        return _length;
    }

    public string GetSummary()
    {
        string dateText = _date.ToString("dd MMM yyyy");
        string activityName = GetName();

        string summary = $"{dateText} {activityName} ({_length} min) - Distance {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile";

        return summary;

    }
}