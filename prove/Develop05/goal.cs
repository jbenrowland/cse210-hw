class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = false;  // Initialize IsCompleted to false by default
    }

    // Property for IsCompleted
    public bool IsCompleted
    {
        get { return _isCompleted; }
        set { _isCompleted = value; }
    }

    // This method can be overridden by subclasses if needed
    public virtual int RecordEvent()
    {
        _isCompleted = true; // Mark the goal as completed for simplicity
        return _points;
    }

    public virtual string GetStatus()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }

    public virtual string GetInfo()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }

    public int GetPoints()
    {
        return _points;
    }

    // You can remove GetIsCompleted as you are using the IsCompleted property directly
}
