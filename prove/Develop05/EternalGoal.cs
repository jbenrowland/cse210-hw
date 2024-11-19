class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // For eternal goals, you can allow multiple recordings
        if (!IsCompleted) 
        {
            return _points;  // Always returns points, but doesn't mark as completed
        }
        return 0;  // No points after it's marked completed
    }
}
