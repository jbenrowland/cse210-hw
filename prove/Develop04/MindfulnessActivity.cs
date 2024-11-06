abstract class MindfulnessActivity
{
    protected int duration; // Variable to hold the duration of the activity

    // Method to start the activity
    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"\nStarting {activityName}..."); // Output the starting message
        Console.WriteLine(description); // Output the activity description
        Console.Write("Enter the duration in seconds: "); // Prompt user for duration
        duration = int.Parse(Console.ReadLine()); // Read user Input and convert to integer
        Console.WriteLine("Prepare to begin..."); // Notify user to prepare
        PauseWithAnimation(3); // Call method to pause with animation for 3 seconds
    }
    // My Method to end the Activity 
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++) // Loop for the specified number of seconds
        {
            Console.Write(". "); // Print a dot for each second
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine(); // Move to the next line after the loop
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine($"Good job! You completed the {activityName} for {duration} seconds."); // Congraulate user
        PauseWithAnimation(2); //Call Method to pause with animation for 2 seconds
    }

    public abstract void Run(); // Abstract method to be implemented by each activity
}
