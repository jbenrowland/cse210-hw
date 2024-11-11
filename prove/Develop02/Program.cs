using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal(5);  
        string userInput;

        do
        {
            Console.WriteLine("\nWelcome to the Journal Menu! Here are your options:");
            Console.WriteLine("1. Create a new entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Exit Program"); 
            Console.Write("Choose an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    var random = new Random();
                    var prompt = journal.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your Response: ");
                    var response = Console.ReadLine();
                    Console.Write("Enter Location (optional): ");
                    var location = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response, location));
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;
            }

        } while (userInput != "3");

        Console.WriteLine("Exiting the program. Goodbye!");
    }
}
