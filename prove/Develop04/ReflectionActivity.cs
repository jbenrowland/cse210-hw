class ReflectionActivity : Activity
{
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?"
    };
    public ReflectionActivity() 
        : base("Reflection Activity", "This activity helps you reflect on times when you showed strength and resilience.")
    {
    }
    public void Perform()
    {
        Start();  
        Random random = new Random();
        int elapsed = 0;
        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        DisplayAnimation(3);
        while (elapsed < _duration)
        {
            Console.WriteLine(_questions[random.Next(_questions.Length)]);
            DisplayAnimation(3); 
            elapsed += 3;  
        }

        End();  
    }
}
