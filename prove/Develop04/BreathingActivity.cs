class BreathingActivity
{
    public void Run()
    {
        Console.WriteLine("\nStarting Breathing Activity...");
        for (int i = 0; i < 3; i++) 
        {
            Console.Write("Breathe in...");
            Delay(3); 
            Console.Write("\rBreathe out...");
            Delay(3); 
            Console.WriteLine("\r                      \r"); 
        }
        Console.WriteLine("Breathing activity complete.");
    }

    private void Delay(int seconds)
    {
        int end = Environment.TickCount + (seconds * 1000);
        while (Environment.TickCount < end) { }
    }
}