class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override int RecordEvent()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            return _points;
        }
        return 0;
    }
}

