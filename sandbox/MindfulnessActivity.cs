abstract class MindfulnessActivity
{
    protected int duration; 

    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"\nStarting {activityName}...");
        Console.WriteLine(description); 
        Console.Write("Enter the duration in seconds: "); 
        duration = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Prepare to begin..."); 
        PauseWithAnimation(3); 
    }
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++) 
        {
            Console.Write(". "); 
            Thread.Sleep(1000);
        }
        Console.WriteLine(); 
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine($"Good job! You completed the {activityName} for {duration} seconds."); 
        PauseWithAnimation(2); 
    }

    public abstract void Run(); 
}
