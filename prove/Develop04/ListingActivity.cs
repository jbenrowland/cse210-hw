class ListingActivity : Activity
{
    private string[] prompts = new string[] {
        "List people who have positively impacted your life.",
        "List things you are grateful for today.",
        "List skills you are proud of.",
        "List moments that made you smile recently."
    };
    public ListingActivity()
    {
        name = "Listing";
        description = "This activity helps you focus on positive aspects of your life by listing as many as you can.";
    }
    public void Perform()
    {
        Start();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(0, prompts.Length)]);
        DisplayAnimation(3);
        int count = 0;
        int endTime = Environment.TickCount + (duration * 1000);
        while (Environment.TickCount < endTime)
        {
            Console.Write("List an item: ");
            string item = Console.ReadLine();
            if (item != null && item.Length > 0)
            {
                count++;
            }
        }
        Console.WriteLine("You listed " + count + " items.");
        End();
    }
}