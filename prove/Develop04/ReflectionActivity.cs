class ReflectionActivity
{
    public void Run()
    {
        Console.WriteLine("\nStarting Reflection Activity...");
        
        string[] questions = {
            "What are you grateful for today?",
            "What challenges did you overcome recently?",
            "What brings you joy?"
        };

        // Select a question based on the current second
        int questionIndex = DateTime.Now.Second % questions.Length;
        string question = questions[questionIndex];

        Console.WriteLine($"Reflect on this question: {question}");
        Delay(5); // 5-second delay
        Console.WriteLine("Reflection activity complete.");
    }

    private void Delay(int seconds)
    {
        int end = Environment.TickCount + (seconds * 1000);
        while (Environment.TickCount < end) { }
    }
}