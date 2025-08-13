public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {_points}");

    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == false)
        {
            return $"[ ] {_shortName} ({_description})";
        }

        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal:{_shortName},{_description},{_points},{IsComplete()}";
    }
}