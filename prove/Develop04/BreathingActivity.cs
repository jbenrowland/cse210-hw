class BreathingActivity
{
    public void Run()
    {
        Console.WriteLine("\nStarting Breathing Activity...");
        for (int i = 0; i < 3; i++) // Loop for a few cycles
        {
            Console.Write("Breathe in...");
            Delay(3); // 3-second delay
            Console.Write("\rBreathe out...");
            Delay(3); // 3-second delay
            Console.WriteLine("\r                      \r"); // Clear line for next cycle
        }
        Console.WriteLine("Breathing activity complete.");
    }

    private void Delay(int seconds)
    {
        int end = Environment.TickCount + (seconds * 1000);
        while (Environment.TickCount < end) { }
    }
}