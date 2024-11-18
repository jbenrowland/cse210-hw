using System;

class Program
{ //added an integer tracker to see what the count is at to exceed the requirements
static int breathingCount = 0;
static int reflectionCount = 0;
static int listingCount = 0;

static void Main()
{
    bool running = true;
    while (running)
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine($"Breathing Activity Count: {breathingCount}");
        Console.WriteLine($"Reflection Activity Count: {reflectionCount}");
        Console.WriteLine($"Listing Activity Count: {listingCount}");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            breathingCount++;
            BreathingActivity breathing = new BreathingActivity();
            breathing.Perform();
        }
        else if (choice == "2")
        {
            reflectionCount++;
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Perform();
        }
        else if (choice == "3")
        {
            listingCount++;
            ListingActivity listing = new ListingActivity();
            listing.Perform();
        }
        else if (choice == "4")
        {
            running = false;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
    Console.WriteLine("Goodbye!");
}
}