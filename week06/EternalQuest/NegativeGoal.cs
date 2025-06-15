public class NegativeGoal : Goal
{
    private bool _isRecorded;

    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isRecorded = false;
    }

    // For loading from file
    public NegativeGoal(string name, string description, int points, bool isRecorded)
        : base(name, description, points)
    {
        _isRecorded = isRecorded;
    }

    public override int RecordEvent()
    {
        if (!_isRecorded)
        {
            _isRecorded = true;
            // Return negative points (subtract from score)
            return -_points;
        }
        return 0;
    }

    public override string GetStatus() => _isRecorded ? "[X]" : "[ ]";
    public override string GetDetailsString() => $"{GetStatus()} {_name} ({_description}) - Bad Habit";

    public override string GetSaveString()
        => $"NegativeGoal:{_name}|{_description}|{_points}|{_isRecorded}";
}
