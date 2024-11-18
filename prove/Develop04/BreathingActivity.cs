class BreathingActivity : Activity
{
   
    public BreathingActivity() 
        : base("Breathing Activity", "This activity helps you relax by guiding you through breathing in and out slowly.")
    {
    }

   
    public void Perform()
    {
        Start();  

        int elapsed = 0;
        int duration = _duration;

        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            Countdown(3);  
            Console.WriteLine("Breathe out...");
            Countdown(3);  
            elapsed += 6; 
        }

        End();  
}
}