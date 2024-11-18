class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
    {
        Console.WriteLine("Activity: " + name);
        Console.WriteLine(description);
        Console.Write("Enter duration (seconds): ");
        duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        DisplayAnimation(3);
    }

    public void End()
    {
        Console.WriteLine("Well done! You completed the " + name + " activity for " + duration + " seconds.");
        DisplayAnimation(3);
    }

    protected void DisplayAnimation(int seconds)
    {
        int end = Environment.TickCount + (seconds * 1000);
        while (Environment.TickCount < end)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "...\r");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
