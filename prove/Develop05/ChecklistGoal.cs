class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            IsCompleted = true; // Set IsCompleted to true when target is reached
            return _points + _bonusPoints; // Return points with bonus when completed
        }
        return _points; // Return only points if not completed yet
    }

    public override string GetStatus()
    {
        return $"{base.GetStatus()} Completed {_timesCompleted}/{_targetCount} times";
    }
}
