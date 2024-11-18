class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?"
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity helps you reflect on times when you showed strength and resilience.";
    }

    public void Perform()
    {
        Start();
        Random random = new Random();
        int elapsed = 0;

        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        DisplayAnimation(3);

        while (elapsed < duration)
        {
            Console.WriteLine(questions[random.Next(questions.Length)]);
            DisplayAnimation(3);
            elapsed += 3;
        }

        End();
    }
}
