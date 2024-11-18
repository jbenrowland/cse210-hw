 class BreathingActivity : Activity
    {
        public BreathingActivity() : base("Breathing Activity", "Inhale and exhale slowly to calm your mind.", 5)
        { }

        public override void Run()
        {
            base.Run();
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
    }