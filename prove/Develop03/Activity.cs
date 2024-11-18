class Activity
{
    public string Name;
    public string Description;
    public int Duration;

    // Constructor definition matching the parameters
    public Activity(string name, string description, int duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
    }

    public virtual void Run()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
        Delay(Duration);
        Console.WriteLine($"{Name} activity complete.");
    }

    protected void Delay(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}

