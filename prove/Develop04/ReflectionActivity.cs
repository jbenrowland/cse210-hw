class ReflectionActivity : Activity
    {
        public ReflectionActivity() : base("Reflection Activity", "Reflect on a question to deepen your thoughts.", 5)
        { }

        public override void Run()
        {
            base.Run();
            string[] questions = {
                "What are you grateful for today?",
                "What challenges did you overcome recently?",
                "What brings you joy?"
            };

            int questionIndex = DateTime.Now.Second % questions.Length;
            string question = questions[questionIndex];

            Console.WriteLine($"Reflect on this question: {question}");
            Delay(Duration);
            Console.WriteLine("Reflection activity complete.");
        }
    }
}