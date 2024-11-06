//Im gonna put a lot of notes in this one to help me remember what everything does
using System; //Import the System namespace for basic functionalities
using System.Collections.Generic; // Imports the Collections.Generic namespace for using lists
using System.Threading; // Import the Threading namespace for sleep functionality

// Base class for mindfulness activities
abstract class MindfulnessActivity
{
    protected int duration; // Variable to hold the duration of the activity

    // Method to start the activity
    public void StartActivity(string activityName, string description)
    {
        Console.WriteLine($"\nStarting {activityName}..."); // Output the starting message
        Console.WriteLine(description); // Output the activity description
        Console.Write("Enter the duration in seconds: "); // Prompt user for duration
        duration = int.Parse(Console.ReadLine()); // Read user Input and convert to integer
        Console.WriteLine("Prepare to begin..."); // Notify user to prepare
        PauseWithAnimation(3); // Call method to pause with animation for 3 seconds
    }
    // My Method to end the Activity 
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++) // Loop for the specified number of seconds
        {
            Console.Write(". "); // Print a dot for each second
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine(); // Move to the next line after the loop
    }

    public void EndActivity(string activityName)
    {
        Console.WriteLine($"Good job! You completed the {activityName} for {duration} seconds."); // Congraulate user
        PauseWithAnimation(2); //Call Method to pause with animation for 2 seconds
    }

    public abstract void Run(); // Abstract method to be implemented by each activity
}

// Breathing Activity class
class BreathingActivity : MindfulnessActivity
{
        // Implementation of the Run method specific to Breathing Activity
    public override void Run()
    {
        // Start the activity with a specific to Breathing Activity
        StartActivity("Breathing Activity", 
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.");

        int elapsed = 0; // Variable to track elapsed time
        while (elapsed < duration) // Loop while the elapsed time is less than the duration
        {
            Console.WriteLine("Breathe in..."); // Prompt user to breath in
            PauseWithAnimation(3); // Inherited Pause animations
            Console.WriteLine("Breathe out..."); // Prompt user to breathe out
            PauseWithAnimation(3); // Pause for 3 seconds to allow breathing out
            elapsed += 6; // Increment elapsed time by 6 seconds (3 seconds for each breath)
        }

        EndActivity("Breathing Activity"); // Call method to end the activity
    }
}

// Reflection Activity class
class ReflectionActivity : MindfulnessActivity
{
        // List of prompts for the reflection activity
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    // List of questions for reflection
    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    // Implementation of the Run method specific to Reflection Activity
    public override void Run()
    {
        StartActivity("Reflection Activity", 
            "This activity will help you reflect on times in your life when you showed strength and resilience. Recognize your power and how you can use it.");

        Random rand = new Random();

        // Display a random prompt to the user
        Console.WriteLine(prompts[rand.Next(prompts.Count)]); // Select a random prompt from the list
        Console.WriteLine("Press Enter when you're ready to move to the next question..."); // Instructions to the user
        Console.ReadLine(); // Wait for user to press Enter to start the questions

        int elapsed = 0; // Variable to track elapsed time
        while (elapsed < duration) // Loop while the elapsed time is less than the duration
        {
            // Display a random question
            string question = questions[rand.Next(questions.Count)]; // Select a random question from the list
            Console.WriteLine(question); // Output the selected question

            // Wait for the user to press Enter to move to the next question
            Console.WriteLine("Press Enter to reflect on the next question...");
            Console.ReadLine(); // Wait for the user input

            // Instead of a timed pause, we just add a fixed time to the elapsed time for each question
            elapsed += 5; // Assume each question takes about 5 seconds of reflection (or adjust as needed)
        }

        EndActivity("Reflection Activity"); // Call method to end activity
    }
}

// Listing Activity class
class ListingActivity : MindfulnessActivity
{
    // List of prompts for the listening activity
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peaceful recently?",
        "Who are some of your personal heroes?"
    };
// Implementation of the Run method specific to Listing Activity
    public override void Run()
    {
        StartActivity("Listing Activity", 
            "This activity will help you reflect on the positive things in your life by listing as many as you can.");

        Random rand = new Random(); // Create a new Random object for generating random numbers
        Console.WriteLine(prompts[rand.Next(prompts.Count)]); // Select and display a random prompt from the list
        PauseWithAnimation(3); // Pause for 3 seconds

        int count = 0; // Variable to count the number of items listed
        int elapsed = 0; // Variable to track elapsed time
        while (elapsed < duration) // Loop while the elapsed time is less than the duration
        {
            Console.Write("Enter a positive item: "); // Prompt user to enter a positive item
            Console.ReadLine(); // Read user input
            count++; // Increment the count of items listed
            elapsed += 2; // Increment elapsed time by 2seconds for each item entered
        }

        Console.WriteLine($"You listed {count} items."); // Output the total number of items listed
        EndActivity("Listing Activity"); // Call method to end the activity
    }
}

// Main Program class
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }
}
